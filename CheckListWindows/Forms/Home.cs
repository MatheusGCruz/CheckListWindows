using CheckListWindows.apiInterface;
using CheckListWindows.ApiInterface;
using CheckListWindows.Auxiliary;
using CheckListWindows.Configs;
using CheckListWindows.Forms;
using CheckListWindows.models;
using CheckListWindows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CheckListWindows
{
    public partial class Home : Form
    {

        int pointX = 1;
        int pointY = 1;
        bool isCreatingNewList = false;
        bool isCreatingNewItem = false;
        bool isUserConnected = false;
        bool isUserValid = false;
        bool hasActiveList = false;
        bool hasActiveItem = false;
        private bool isFormPined = false;
        private int activeListId = 0;

        public bool isConfigChanged = false;
        private Point _mouseLoc;

        private ShowChecklistNameDto activeList = new ShowChecklistNameDto();


        //Active itens - itens that is showed to user
        List<ShowChecklistNameDto> listNames = new List<ShowChecklistNameDto>();
        List<ChecklistNameDto> ownedLists = new List<ChecklistNameDto>();
        List<ShowChecklistItemDto> activeItensList = new List<ShowChecklistItemDto>();
        List<ShowChecklistItemDto> allItemsList = new List<ShowChecklistItemDto>();

        //ShadownItens - Itens that generates a shadow (background items)
        List<ShowChecklistNameDto> shadowListNames = new List<ShowChecklistNameDto>();
        List<ChecklistNameDto> shadowOwnedLists = new List<ChecklistNameDto>();
        List<ShowChecklistItemDto> shadowActiveItensList = new List<ShowChecklistItemDto>();
        List<ShowChecklistItemDto> shadowAllItemsList = new List<ShowChecklistItemDto>();



        public Home()
        {
                       
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //initiateImages();
            setBasicConfigs();
            fillItens(true);
            setBasicUserConfigs();       
            
        }

        private void setBasicConfigs()
        {
            this.BackColor = auxiliaryConfigs.getBackGroundColor();
            this.ForeColor = auxiliaryConfigs.getTextColorConfig();
            listItensPanel.BackColor = auxiliaryConfigs.getBackGroundColor();
            listItensPanel.ForeColor = auxiliaryConfigs.getTextColorConfig();
            titlePanel.BackColor = auxiliaryConfigs.getDarkerBackgroundColor();
            titlePanel.ForeColor = auxiliaryConfigs.getLighterTextColor();
            titlePanel.BorderStyle = BorderStyle.FixedSingle;
        }

        private void setBasicUserConfigs()
        {
            if (!isUserConnected)
            {
                if (!AuthApiInterface.isUserInserted())
                {
                    showSettingsForm();
                }
                connStatus();
            }

            auxiliaryConfigs.shadownTimerValue = ConfigurationManager.AppSettings.Get("shadownTimerValue");
            auxiliaryConfigs.refreshTimerValue = ConfigurationManager.AppSettings.Get("refreshTimerValue");
            setTimers();
        }

        private void setTimers()
        {
            try
            {
                int shadowRefreshPeriod = Int32.Parse(auxiliaryConfigs.shadownTimerValue);
                int listRefreshPeriod = Int32.Parse(auxiliaryConfigs.refreshTimerValue);


                shadowRefreshTimer.Interval = (shadowRefreshPeriod * 1000); // 45 mins
                shadowRefreshTimer.Start();

                listRefreshTimer.Interval = (listRefreshPeriod * 1000); // 45 mins
                listRefreshTimer.Start();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }

        private void generateLists(ShowChecklistNameDto list, int pointY)
        {
            if (!isCreatingNewList || list.checklist.id != 0)
            {
                Label LB = new Label();
                LB.Name = TextEditions.generateLabelName("list", list.checklist.id);
                LB.Location = new Point(pointX, (20 * pointY) + 25);
                LB.Size = new Size(500, 13);
                LB.Text = TextEditions.getListText(list);
                LB.Click += new EventHandler(listClick); //assign click handler
                LB.Font = FontsEdits.listChange(LB.Font, list.isActive, list.checklist.id, list.isCompleted);
                listItensPanel.Controls.Add(LB);
            }
        }


        private void generateItens(ShowChecklistItemDto item, int pointY)
        {
            if (!isCreatingNewItem || item.checkItem.id != 0)
            {
                Label LB = new Label();
                LB.Name = TextEditions.generateLabelName("item", item.checkItem.id);
                LB.Location = new Point(pointX, (20 * pointY) + 25);
                LB.Size = new Size(500, 13);
                LB.Text = TextEditions.getItemText(item);
                LB.Font = FontsEdits.itemChange(LB.Font, item.checkItem.id, (item.checkItem.checkedBy != null), false);
                if (item.checkItem.id > 0)
                {
                    LB.DoubleClick += new EventHandler(listItemDoubleClick); //assign click handler
                }
                else if(item.checkItem.id == 0)
                {
                    LB.Click += new EventHandler(listItemClick); //assign click handler
                }
                listItensPanel.Controls.Add(LB);
            }
        }

        private void refreshCache()
        {
            refreshShow(true);
            shadowListNames = new List<ShowChecklistNameDto>();
            shadowAllItemsList = new List<ShowChecklistItemDto>();


            shadowListNames = ChecklistApiInterface.getListNames();
            shadowOwnedLists = ChecklistApiInterface.getOwnedLists();

            foreach (ShowChecklistNameDto listName in shadowListNames)
            {
                List<ShowChecklistItemDto> itemsByList = new List<ShowChecklistItemDto>();
                shadowAllItemsList.AddRange( ChecklistApiInterface.getListItens(listName.checklist.id));
            }

            shadowListNames.Add(NewItemsInterface.addChecklistNameDto());


            foreach (ShowChecklistNameDto listName in shadowListNames)
            {
                int itensQuantity = 0;
                int checkedItens = 0;
                foreach(ShowChecklistItemDto showChecklistItemDto in shadowAllItemsList)
                {
                    if(showChecklistItemDto.checkItem.checklistId == listName.checklist.id)
                    {
                        itensQuantity++;
                        if (showChecklistItemDto.checkItem.checkedBy != null)
                        {
                            checkedItens++;
                        }
                    }
                }
                listName.numItens = itensQuantity;
                listName.chkItens = checkedItens;

                foreach (ChecklistNameDto ownedList in shadowOwnedLists)
                {
                    if (ownedList.id == listName.checklist.id)
                    {
                        listName.isOwned = true;
                    }
                }

                if (itensQuantity > 0 && itensQuantity == checkedItens)
                {
                    listName.isCompleted = true;
                }
            }

            applyShadows();
            refreshShow(false);
        }

        private void applyShadows()
        {
            shadowActiveItensList = new List<ShowChecklistItemDto>();
            foreach(ShowChecklistNameDto shadowListName in shadowListNames)
            {
                if(shadowListName.checklist.id == activeListId && activeListId>0 )
                {
                    shadowListName.isActive = true;
                    foreach(ShowChecklistItemDto itemDto in shadowAllItemsList)
                    {
                        if(itemDto.checkItem.checklistId == activeListId)
                        {
                            shadowActiveItensList.Add(itemDto);
                        }
                    }
                }
            }

            listNames = new List<ShowChecklistNameDto>();
            activeItensList = new List<ShowChecklistItemDto>();
            allItemsList = new List<ShowChecklistItemDto>();
            ownedLists = new List<ChecklistNameDto>();

            listNames.AddRange(shadowListNames);
            activeItensList.AddRange(shadowActiveItensList);
            allItemsList.AddRange(shadowAllItemsList);
            ownedLists.AddRange(shadowOwnedLists);
        }

        private void refreshShow(bool isRefreshing)
        {
            refreshPictBox.Visible = isRefreshing;
        }


        protected void listClick(object sender, EventArgs e)
        {
            refreshShow(true);
            Label lbl = sender as Label;
            if (lbl != null)
            {
                isNotCreating();
                if (lbl.Name == "newlist")
                {
                    isCreatingNewList = true;
                }
                foreach (ShowChecklistNameDto list in listNames)
                {
                    if(lbl.Name == "list-" + list.checklist.id)
                    {
                        list.isActive = !list.isActive;
                        if (list.isActive)
                        {
                            activeListId = list.checklist.id;
                            hasActiveList = true;
                            activeList = list;
                            showShare(list.isOwned);
                            showTrash(list.isOwned);
                        }
                        else {
                            activeListId = 0;
                            hasActiveList = false;
                            activeList = new ShowChecklistNameDto();
                            showShare(false);
                            showTrash(false);
                        }
                    }
                    else
                    {
                        list.isActive = false;
                    }
                }
                
                fillItens(false);
            }
            refreshShow(false);
        }

        protected void listItemClick(object sender, EventArgs e)
        {
            refreshShow(true);
            Label lbl = sender as Label;
            if (lbl != null)
            {
                isNotCreating();
                if (lbl.Name == "newitem")
                {
                    isCreatingNewItem = true;

                }
                foreach (ShowChecklistItemDto activeItem in activeItensList)
                {

                    if (lbl.Name == "item-" + activeItem.checkItem.id)
                    {
                        hasActiveItem = !hasActiveItem;
                        lbl.Font = FontsEdits.itemChange(lbl.Font, activeItem.checkItem.id, (activeItem.checkItem.checkedBy != null), true);
                        // item clicked
                    }
                    else
                    {
                        //item without click
                    }
                }
                fillItens(false);
            }
            refreshShow(false);
        }

        protected void listItemDoubleClick(object sender, EventArgs e)
        {
            refreshShow(true);
            Label lbl = sender as Label;
            if (lbl != null)
            {
                isNotCreating();
                foreach (ShowChecklistItemDto activeItem in activeItensList)
                {
                    if (lbl.Name == "item-" + activeItem.checkItem.id)
                    {
                        hasActiveItem = !hasActiveItem;
                        if (ChecklistApiInterface.checkItem(activeItem.checkItem))
                        {
                            closeAndRefresh();
                        }
                    }
                }
                fillItens(false);
            }
            refreshShow(false);
        }

        protected void cancelItem(object sender, EventArgs e)
        {
            closeAndRefresh();
        }

        private List<ShowChecklistItemDto> addItensToActiveList(int listId)
        {
            List<ShowChecklistItemDto> activeItensByListId = new List<ShowChecklistItemDto>();

            foreach(ShowChecklistItemDto showChecklistItemDto in allItemsList)
            {
                if(showChecklistItemDto.checkItem.checklistId == listId)
                {
                    activeItensByListId.Add(showChecklistItemDto);
                } 
            }
            activeItensByListId.Add(NewItemsInterface.addChecklistItemDto());
            return activeItensByListId;
        }


        private void fillItens(bool refreshListNames)
        {
            refreshShow(true);
            showConfirmCancel(false);

            listItensPanel.Controls.Clear();
            pointY = 1;
            if (refreshListNames)
            {
                refreshCache();
            }            

            foreach (ShowChecklistNameDto list in listNames)
            {
                generateLists(list, pointY);
                pointY++;

                if(list.isActive)
                {
                    activeItensList = addItensToActiveList(list.checklist.id);
                    pointY++;
                    foreach (ShowChecklistItemDto item in activeItensList)
                    {
                        generateItens(item, pointY);
                        pointY++;
                    }
                    if (isCreatingNewItem)
                    {
                        createNewItemTextbox();
                    }
                    pointY++;
                }
            }

            if (isCreatingNewList)
            {
                createNewListTextbox();
            }
            refreshShow(false);
        }

        private void initiateImages()
        {
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            this.BackgroundImage = System.Drawing.Image.FromFile("C://Users//mathe//Downloads//post-it.png");
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        }

        private void initiatePanel()
        {
            listItensPanel.Dock = DockStyle.Fill;
            listItensPanel.BorderStyle = BorderStyle.Fixed3D;
        }




        private void createNewListTextbox()
        {
            showConfirmCancel(true);
            TextBox TX = new TextBox();
            TX.Name = "createdList";
            TX.Location = new Point(pointX , (20 * pointY) + 5);
            TX.Size = new Size(500, 13);
            TX.Text = "new list name";
            TX.Font = FontsEdits.newItemBoldFont(TX.Font);
            TX.BorderStyle = BorderStyle.FixedSingle;
            TX.ForeColor = auxiliaryConfigs.getTextColorConfig();
            TX.BackColor = auxiliaryConfigs.getBackGroundColor();
            //TX.Click += new EventHandler(createNewItem()); //assign click handler
            listItensPanel.Controls.Add(TX);
        }

        private void createNewItemTextbox()
        {
            showConfirmCancel(true);
            TextBox TX = new TextBox();
            TX.Name = "createdItem";
            TX.Location = new Point(pointX, (20 * pointY) + 5);
            TX.Size = new Size(500, 13);
            TX.Text = "new item name";
            TX.Font = FontsEdits.newItemBoldFont(TX.Font);
            TX.BorderStyle = BorderStyle.FixedSingle;
            TX.ForeColor = auxiliaryConfigs.getTextColorConfig();
            TX.BackColor = auxiliaryConfigs.getBackGroundColor();
            //TX.Click += new EventHandler(createNewItem()); //assign click handler
            listItensPanel.Controls.Add(TX);

        }

        private void isNotCreating()
        {
            isCreatingNewItem = false;
            isCreatingNewList = false;
        }


        private void HomeMouseDown(object sender, MouseEventArgs e)
        {
            if (!isFormPined)
            {
                _mouseLoc = e.Location;
            }
            
        }

        private void HomeMouseMove(object sender, MouseEventArgs e)
        {
            if (!isFormPined)
            {
                if (e.Button == MouseButtons.Left)
                {
                    int dx = e.Location.X - _mouseLoc.X;
                    int dy = e.Location.Y - _mouseLoc.Y;
                    this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
                }
            }
        }

        private void pinBtn_Click(object sender, EventArgs e)
        {
            isFormPined = !isFormPined;
            if (isFormPined)
            {
                pinPictBox.Image = Properties.Resources.pin_red;
                pinPictBox.BackgroundImage = Properties.Resources.pin_red;
                this.TopMost = true;
                
            }
            else
            {
                pinPictBox.Image = Properties.Resources.pin_white;
                pinPictBox.BackgroundImage = Properties.Resources.pin_white;
                this.TopMost = false;


            }
        }

        private void connStatus()
        {
            AuthApiInterface.getChecklistToken();

            if (ConfigurationManager.AppSettings.Get("checklistToken") == "NONE")
            {
                connPictBox.BackgroundImage = Properties.Resources.wifi_white;
            }
            else
            {
                connPictBox.BackgroundImage = Properties.Resources.wifi_blue;
            }

        }

        private void refreshConnection(object sender, EventArgs e)
        {
            connStatus();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            showSettingsForm();
        }

        private void shareClick(object sender, EventArgs e)
        {
            showShareForm();
        }

        private void closeAndRefresh()
        {
            isCreatingNewItem = false;
            isCreatingNewList = false;
            refreshCache();
            fillItens(false);
        }


        // Open forms

        private void showSettingsForm()
        {
            UserSettingsForm userSettingsForm = new UserSettingsForm();
            userSettingsForm.ShowDialog();

            if(userSettingsForm.DialogResult == DialogResult.OK)
            {
                setBasicConfigs();
                setBasicUserConfigs();
                refreshCache();
                fillItens(false);
            }

        }

        private void showShareForm()
        {
            foreach (ShowChecklistNameDto list in listNames)
            {
                if (list.isActive)
                {
                    ShareForm shareForm = new ShareForm();
                    shareForm.loadNewList(list.checklist);
                    var dialogResult = shareForm.ShowDialog();
                }
            }
        }

        private void createNewList(object sender, EventArgs e)
        {
            refreshShow(true);

            refreshShow(false);
        }

        private void createNewItem(object sender, EventArgs e)
        {


        }

        private void listRefreshTimer_Tick(object sender, EventArgs e)
        {
            if (auxiliaryConfigs.isConfigChanged)
            {
                auxiliaryConfigs.isConfigChanged = false;
                setBasicConfigs();
                setBasicUserConfigs();
            }
            if(!isCreatingNewItem && !isCreatingNewList)
            {
                fillItens(false);
            }
            
        }

        private void shadowRefreshTimer_Tick(object sender, EventArgs e)
        {
            refreshCache();
        }

        private bool checkSelectedItem()
        {
            return false;
        }

        private void showConfirmCancel(bool showFlag)
        {
            confirmPicBox.Enabled = showFlag;
            cancelPicBox.Enabled = showFlag;

            confirmPicBox.Visible = showFlag;
            cancelPicBox.Visible = showFlag;
        }

        private void showShare(bool showFlag)
        {
            sharePictBox.Visible = showFlag;
            sharePictBox.Enabled = showFlag;
        }

        private void showTrash(bool showFlag)
        {
            trashPicBox.Enabled = showFlag;
            trashPicBox.Visible = showFlag;
        }


        private void cancelCreation()
        {

        }

        private void cancelPicBox_Click(object sender, EventArgs e)
        {
            closeAndRefresh();
        }

        private void confirmPicBox_Click(object sender, EventArgs e)
        {



            refreshShow(true);

            if (isCreatingNewItem)
            {

                CheckedItemDto newItem = new CheckedItemDto();
                newItem.name = ((TextBox)listItensPanel.Controls["createdItem"]).Text; // createdList.Text;
                newItem.isPermanent = 0;
                newItem.checklistId = activeListId;

                if (ChecklistApiInterface.createNewItem(newItem) && newItem.checklistId > 0)
                {
                    fillItens(true);
                    closeAndRefresh();
                }

            }
            else if (isCreatingNewList)
            {
                var regex = new Regex("[0-9]{3}-[0-9]{3}");
                string listName = ((TextBox)listItensPanel.Controls["createdList"]).Text;

                if (regex.IsMatch(listName))
                {
                    ChecklistApiInterface.AddSharedList(listName);
                }
                else
                {
                    ChecklistNameDto newList = new ChecklistNameDto();
                    newList.name = ((TextBox)listItensPanel.Controls["createdList"]).Text; // createdList.Text;
                    newList.isPermanent = 0;
                    ChecklistApiInterface.createNewList(newList);
                }

                refreshCache();
                closeAndRefresh();
            }

            refreshShow(false);
        }

        private void trashPicBox_Click(object sender, EventArgs e)
        {
            ChecklistApiInterface.RemoveList(activeList);
        }
    }

}
        
