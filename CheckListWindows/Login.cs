using CheckListWindows.apiInterface;
using CheckListWindows.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CheckListWindows
{
    public partial class Login : Form
    {
        private Boolean isNewUser = false;
        public Login()
        {
            InitializeComponent();
            registerEnable(false);
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            registerEnable(true);

        }



        private void registerEnable(Boolean register)
        {
            confirmPasswordLbl.Visible = register;
            confirmPasswordLbl.Enabled = register;
            confirmPasswordTxt.Visible = register;
            confirmPasswordTxt.Enabled = register;

            inviteLbl.Visible = register;
            inviteLbl.Enabled = register;
            inviteTxt.Visible = register;
            inviteTxt.Enabled = register;

            isNewUser = register;

            registerBtn.Visible = !register;
            registerBtn.Enabled = !register;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            AuthUserDto activeUser = new AuthUserDto();
            activeUser = generateUserObject();

            String inviteCode = inviteTxt.Text;
            String authApiResponse = "";

            if (isNewUser)
            {
                authApiResponse = AuthApiInterface.createUser(inviteCode, activeUser);
            }

            messageLabel.Text = authApiResponse;
        }

        private AuthUserDto generateUserObject() {
            AuthUserDto generatedUser = new AuthUserDto();
            generatedUser.username = userTxt.Text;
            generatedUser.password = passwordTxt.Text;

            return generatedUser;
        }
    }
}
