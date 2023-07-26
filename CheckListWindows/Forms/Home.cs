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
        private bool isFormPined = false;

        private Point _mouseLoc;
        List<ShowChecklistNameDto> listNames = new List<ShowChecklistNameDto>();
        List<ShowChecklistItemDto> activeItensList = new List<ShowChecklistItemDto>();

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
                LB.Font = FontsEdits.listChange(LB.Font, list.isActive, list.checklist.id);
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
                LB.Click += new EventHandler(listItemClick); //assign click handler
                listItensPanel.Controls.Add(LB);
            }

        }



        protected void listClick(object sender, EventArgs e)
        {
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
                    }
                    else
                    {
                        list.isActive = false;
                    }
                }
                
                fillItens(false);
            }
        }

        protected void listItemClick(object sender, EventArgs e)
        {
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
                        // item clicked
                    }
                    else
                    {
                        //item without click
                    }
                }
                fillItens(false);
            }
        }


        private void fillItens(bool refreshListNames)
        {
            listItensPanel.Controls.Clear();
            pointY = 1;
            if (refreshListNames)
            {
                listNames = ChecklistApiInterface.getListNames();
                listNames.Add(NewItemsInterface.addChecklistNameDto());
            }
            

            foreach (ShowChecklistNameDto list in listNames)
            {
                generateLists(list, pointY);
                pointY++;

                if(list.isActive)
                {
                    activeItensList = ChecklistApiInterface.getListItens(list.checklist.id);
                    activeItensList.Add(NewItemsInterface.addChecklistItemDto());
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



        private void createType(String type)
        {
            int teste = 0;
        }

        private void createNewListTextbox()
        {
            Label LB = new Label();
            LB.Name = "checkIcon";
            LB.Location = new Point(pointX, (20 * pointY) + 5);
            LB.Size = new Size(20, 20);
            LB.Text = Symbols.getCheckMark();
            LB.Click += new EventHandler(listItemClick); //assign click handler
            listItensPanel.Controls.Add(LB);


            TextBox TX = new TextBox();
            TX.Name = "createdList";
            TX.Location = new Point(pointX + 20, (20 * pointY) + 5);
            TX.Size = new Size(480, 13);
            TX.Text = "new list name";
            TX.Font = FontsEdits.newItemBoldFont(TX.Font);
            TX.BorderStyle = BorderStyle.Fixed3D;
            TX.ForeColor = auxiliaryConfigs.getTextColorConfig();
            TX.BackColor = auxiliaryConfigs.getBackGroundColor();
            //TX.Click += new EventHandler(createNewItem()); //assign click handler
            listItensPanel.Controls.Add(TX);
        }

        private void createNewItemTextbox()
        {
            Label LB = new Label();
            LB.Name = "checkIcon";
            LB.Location = new Point(pointX, (20 * pointY) + 5);
            LB.Size = new Size(20, 20);
            LB.Text = Symbols.getCheckMark();
            LB.Click += new EventHandler(listItemClick); //assign click handler
            listItensPanel.Controls.Add(LB);


            TextBox TX = new TextBox();
            TX.Name = "createdItem";
            TX.Location = new Point(pointX+20, (20 * pointY) + 5);
            TX.Size = new Size(480, 13);
            TX.Text = "new item name";
            TX.Font = FontsEdits.newItemBoldFont(TX.Font);
            TX.BorderStyle = BorderStyle.Fixed3D;
            TX.ForeColor = auxiliaryConfigs.getTextColorConfig();
            TX.BackColor = auxiliaryConfigs.getBackGroundColor();
            //TX.Click += new EventHandler(createNewItem()); //assign click handler
            listItensPanel.Controls.Add(TX);

        }

        private EventHandler createNewItem()
        {
            throw new NotImplementedException();
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


        // Open forms

        private void showSettingsForm()
        {
            UserSettingsForm userSettingsForm = new UserSettingsForm();
            userSettingsForm.Show();
        }

        private void showShareForm()
        {
            ShareForm shareForm = new ShareForm();
            shareForm.Show();
        }

    }

}
        
