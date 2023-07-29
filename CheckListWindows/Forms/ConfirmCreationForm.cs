using CheckListWindows.ApiInterface;
using CheckListWindows.Auxiliary;
using CheckListWindows.Configs;
using CheckListWindows.models;
using CheckListWindows.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListWindows.Forms
{
    public partial class ConfirmCreationForm : Form
    {
        private ChecklistNameDto newList = new ChecklistNameDto();
        private ChecklistItemDto newItem = new ChecklistItemDto();

        internal void loadNewList(ChecklistNameDto sendedList)
        {
            newList = sendedList;
            descLbl.Text = "Confirm the creation of the following List: ";
            itemDescLbl.Text = newList.name;
        }

        internal void loadNewItem(ChecklistItemDto sendedItem)
        {
            newItem = sendedItem;
            descLbl.Text = "Confirm the creation of the following Item: ";
            itemDescLbl.Text = newItem.name;
        }

        public ConfirmCreationForm()
        {
            InitializeComponent();
            importStyles();
        }

        private void importStyles()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = auxiliaryConfigs.getBackGroundColor();
            this.ForeColor = auxiliaryConfigs.getTextColorConfig();
            defaultPnl.BackColor = auxiliaryConfigs.getBackGroundColor();
            controlPnl.BackColor = auxiliaryConfigs.getDarkerBackgroundColor();
            descLbl = ColorsStyles.setLabelColors(descLbl);
            itemDescLbl = ColorsStyles.setLabelColors(itemDescLbl);
        }



        private void ConfirmCreationForm_Load(object sender, EventArgs e)
        {

        }

        private bool createList()
        {
            return ChecklistApiInterface.createNewList(newList);

                //fillItens(true);
                //closeAndRefresh();

        }

        private void confirmPictBox_Click(object sender, EventArgs e)
        {
            cyclePictBox.Visible = true;
            confirmPictBox.Enabled = false;

            if (ChecklistApiInterface.createNewList(newList))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            cyclePictBox.Visible = false;
            confirmPictBox.Enabled = true;
        }

        private void cancelPicBox_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
