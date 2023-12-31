﻿using CheckListWindows.apiInterface;
using CheckListWindows.ApiInterface;
using CheckListWindows.Auxiliary;
using CheckListWindows.Configs;
using CheckListWindows.Models;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace CheckListWindows.Forms
{
    public partial class UserSettingsForm : Form
    {
        private bool isNewUser = false;
        private bool isUserLogged = false;

        private string textColor = ConfigurationManager.AppSettings.Get("textColor");
        private string backgroundColor = ConfigurationManager.AppSettings.Get("backgroundColor");
        private int shadowRefresh = Int32.Parse(ConfigurationManager.AppSettings.Get("shadownTimerValue"));

        public UserSettingsForm()
        {
            InitializeComponent();
            initiateStyles();

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (isNewUser)
            {
                createNewUser();
            }

            executeLogin();
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
            if (saveConfigs())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }

        }

        private void cancelBtnClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initiateValues()
        {
            refreshSelector.Value = shadowRefresh;
        }


        private void initiateStyles()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;
            this.BackColor = auxiliaryConfigs.getBackGroundColor();
            this.ForeColor = auxiliaryConfigs.getTextColorConfig();
            usernameLbl = ColorsStyles.setLabelColors(usernameLbl);
            passwordLbl = ColorsStyles.setLabelColors(passwordLbl);
            confirmPassLbl = ColorsStyles.setLabelColors(confirmPassLbl);
            inviteLbl = ColorsStyles.setLabelColors(inviteLbl);
            onlineRefreshLbl = ColorsStyles.setLabelColors(onlineRefreshLbl);

            usernameTxtBox = ColorsStyles.setTextBoxColors(usernameTxtBox);
            passwordTxtBox = ColorsStyles.setTextBoxColors(passwordTxtBox);
            confirmTxtBox = ColorsStyles.setTextBoxColors(confirmTxtBox);
            inviteTxtBox = ColorsStyles.setTextBoxColors(inviteTxtBox);
            exampleTxtBox = ColorsStyles.setTextBoxColors(exampleTxtBox);

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

        private bool saveConfigs()
        {
            try
            {
                SaveConfigInterface.AddOrUpdateAppSettings("username", usernameTxtBox.Text);
                SaveConfigInterface.AddOrUpdateAppSettings("password", passwordTxtBox.Text);
                SaveConfigInterface.AddOrUpdateAppSettings("textColor", textColor);
                SaveConfigInterface.AddOrUpdateAppSettings("backGroundColor", backgroundColor);
                SaveConfigInterface.AddOrUpdateAppSettings("shadownTimerValue", shadowRefresh.ToString());
                SaveConfigInterface.AddOrUpdateAppSettings("refreshTimerValue", (shadowRefresh/3).ToString());

                auxiliaryConfigs.isConfigChanged = true;

                return executeLogin();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        private bool executeLogin()
        {
            SaveConfigInterface.AddOrUpdateAppSettings("checklistToken", "NONE");
            returnMsgLbl.Text = AuthApiInterface.getChecklistToken();
            return !(ConfigurationManager.AppSettings.Get("checklistToken") == "NONE");
        }

        private bool createNewUser()
        {
            if(passwordTxtBox.Text != confirmTxtBox.Text)
            {
                msgLbl.Text = "Password and Confirmation dosn't match.";
                return false;
            }
            else if(inviteTxtBox.Text == "")
            {
                msgLbl.Text = "Invite cannot be null";
                return false;
            }
            else
            {
                AuthUserDto newUser = new AuthUserDto();
                newUser.username = usernameTxtBox.Text;
                newUser.password = passwordTxtBox.Text;
                msgLbl.Text = AuthApiInterface.createUser(inviteTxtBox.Text, newUser);

                return executeLogin();
            }
        }

        private void txtColorBtn_Click(object sender, EventArgs e)
        {
            txtColorPicker.ShowDialog();

            if (txtColorPicker.ShowDialog() == DialogResult.OK)
            {
                exampleTxtBox.ForeColor = txtColorPicker.Color;
                textColor = ColorTranslator.ToHtml(txtColorPicker.Color);
            }
        }

        private void backgroundColorBtn_Click(object sender, EventArgs e)
        {
            txtColorPicker.ShowDialog();

            if (txtColorPicker.ShowDialog() == DialogResult.OK)
            {
                exampleTxtBox.BackColor = txtColorPicker.Color;
                backgroundColor = ColorTranslator.ToHtml(txtColorPicker.Color);
            }
        }

        private void exampleTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void refreshSelector_ValueChanged(object sender, EventArgs e)
        {
            shadowRefresh = Int32.Parse(refreshSelector.Value.ToString());
        }

        private void shutdownPicBox_DoubleClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }
    }
}
