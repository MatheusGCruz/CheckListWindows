using CheckListWindows.Auxiliary;
using CheckListWindows.Configs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckListWindows.Forms
{
    public partial class UserSettingsForm : Form
    {
        private bool isNewUser = false;

        public UserSettingsForm()
        {
            InitializeComponent();
            initiateStyles();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            isNewUser = true;
            enableNewUser(isNewUser);
        }

        private void enableNewUser(bool enableFlag)
        {
            confirmPassLbl.Visible = enableFlag;
            confirmPassLbl.Enabled = enableFlag;
            confirmTxtBox.Enabled = enableFlag;
            confirmTxtBox.Visible = enableFlag;

            inviteLbl.Visible = enableFlag;
            inviteLbl.Enabled = enableFlag;
            inviteTxtBox.Visible = enableFlag;
            inviteTxtBox.Enabled = enableFlag;
        }

        private void confirmBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }


        private void initiateStyles()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = auxiliaryConfigs.getBackGroundColor();
            this.ForeColor = auxiliaryConfigs.getTextColorConfig();
            usernameLbl = ColorsStyles.setLabelColors(usernameLbl);
            passwordLbl = ColorsStyles.setLabelColors(passwordLbl);
            confirmPassLbl = ColorsStyles.setLabelColors(confirmPassLbl);
            inviteLbl = ColorsStyles.setLabelColors(inviteLbl);

            usernameTxtBox = ColorsStyles.setTextBoxColors(usernameTxtBox);
            passwordTxtBox = ColorsStyles.setTextBoxColors(passwordTxtBox);
            confirmTxtBox = ColorsStyles.setTextBoxColors(confirmTxtBox);
            inviteTxtBox = ColorsStyles.setTextBoxColors(inviteTxtBox);

            userPanel = ColorsStyles.setPanelColors(userPanel, false);
            userPanelTitle = ColorsStyles.setPanelColors(userPanelTitle, true);

            settingsPanel = ColorsStyles.setPanelColors(settingsPanel, false);
            settingsPanelTitle = ColorsStyles.setPanelColors(settingsPanelTitle, true);
            subPanel = ColorsStyles.setPanelColors(subPanel, true);



        }

        private void setLabelColors(Label colorObject)
        {
                colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
                colorObject.ForeColor = auxiliaryConfigs.getLighterTextColor();
        }

        private void setTextBoxColors(TextBox colorObject)
        {
                colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
                colorObject.ForeColor = auxiliaryConfigs.getTextColorConfig();
        }

        private void setPanelColors(Panel colorObject, bool isContrast)
        {
            if (isContrast)
            {
                colorObject.BackColor = auxiliaryConfigs.getDarkerBackgroundColor();
                colorObject.ForeColor = auxiliaryConfigs.getLighterTextColor();
            }
            else
            {
                colorObject.BackColor = auxiliaryConfigs.getBackGroundColor();
                colorObject.ForeColor = auxiliaryConfigs.getTextColorConfig();
            }

        }



    }
}
