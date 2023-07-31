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
using System.Text;
using System.Windows.Forms;

namespace CheckListWindows.Forms
{
    public partial class ShareForm : Form
    {
        private Point _mouseLoc;
        private ChecklistNameDto newList = new ChecklistNameDto();


        internal void loadNewList(ChecklistNameDto sendedList)
        {
            newList = sendedList;
            String pinCode = ChecklistApiInterface.generatePinCode(newList);
            if(pinCode != "PinCode Error")
            {
                pinCodeValueLbl.Text = pinCode;
            }
        }

        public ShareForm()
        {
            InitializeComponent();

            initiateStyles();
        }


        private void initiateStyles()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = auxiliaryConfigs.getBackGroundColor();
            this.ForeColor = auxiliaryConfigs.getTextColorConfig();

            sharePanelTitle = ColorsStyles.setPanelColors(sharePanelTitle, false);
            subPanel = ColorsStyles.setPanelColors(subPanel, true);
            sharePanelTitle = ColorsStyles.setPanelColors(sharePanelTitle, true);

        }

        private void HomeMouseDown(object sender, MouseEventArgs e)
        {
            _mouseLoc = e.Location;
        }

        private void HomeMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                {
                    int dx = e.Location.X - _mouseLoc.X;
                    int dy = e.Location.Y - _mouseLoc.Y;
                    this.Location = new Point(this.Location.X + dx, this.Location.Y + dy);
                }
        }

        private void confirmPicBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getPinCode()
        {
            
        }
    }
}
