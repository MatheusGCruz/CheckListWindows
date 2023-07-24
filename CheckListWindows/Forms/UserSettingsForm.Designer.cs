
namespace CheckListWindows.Forms
{
    partial class UserSettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userPanel = new System.Windows.Forms.Panel();
            this.settingsPanel = new System.Windows.Forms.Panel();
            this.subPanel = new System.Windows.Forms.Panel();
            this.userPanelTitle = new System.Windows.Forms.Panel();
            this.settingsPanelTitle = new System.Windows.Forms.Panel();
            this.userPanelLbl = new System.Windows.Forms.Label();
            this.settingsPanelLabel = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.confirmPassLbl = new System.Windows.Forms.Label();
            this.confirmTxtBox = new System.Windows.Forms.TextBox();
            this.inviteLbl = new System.Windows.Forms.Label();
            this.inviteTxtBox = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.confirmPictBox = new System.Windows.Forms.PictureBox();
            this.cancelPictBox = new System.Windows.Forms.PictureBox();
            this.userPanel.SuspendLayout();
            this.settingsPanel.SuspendLayout();
            this.subPanel.SuspendLayout();
            this.userPanelTitle.SuspendLayout();
            this.settingsPanelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userPanel
            // 
            this.userPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanel.Controls.Add(this.loginBtn);
            this.userPanel.Controls.Add(this.registerBtn);
            this.userPanel.Controls.Add(this.inviteTxtBox);
            this.userPanel.Controls.Add(this.inviteLbl);
            this.userPanel.Controls.Add(this.confirmTxtBox);
            this.userPanel.Controls.Add(this.confirmPassLbl);
            this.userPanel.Controls.Add(this.passwordTxtBox);
            this.userPanel.Controls.Add(this.passwordLbl);
            this.userPanel.Controls.Add(this.usernameTxtBox);
            this.userPanel.Controls.Add(this.usernameLbl);
            this.userPanel.Controls.Add(this.userPanelTitle);
            this.userPanel.Location = new System.Drawing.Point(13, 13);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(233, 306);
            this.userPanel.TabIndex = 0;
            // 
            // settingsPanel
            // 
            this.settingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanel.Controls.Add(this.settingsPanelTitle);
            this.settingsPanel.Location = new System.Drawing.Point(253, 12);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Size = new System.Drawing.Size(541, 307);
            this.settingsPanel.TabIndex = 1;
            // 
            // subPanel
            // 
            this.subPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPanel.Controls.Add(this.cancelPictBox);
            this.subPanel.Controls.Add(this.confirmPictBox);
            this.subPanel.Location = new System.Drawing.Point(13, 331);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(780, 47);
            this.subPanel.TabIndex = 2;
            // 
            // userPanelTitle
            // 
            this.userPanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userPanelTitle.Controls.Add(this.userPanelLbl);
            this.userPanelTitle.Location = new System.Drawing.Point(-1, -2);
            this.userPanelTitle.Name = "userPanelTitle";
            this.userPanelTitle.Size = new System.Drawing.Size(233, 57);
            this.userPanelTitle.TabIndex = 0;
            // 
            // settingsPanelTitle
            // 
            this.settingsPanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.settingsPanelTitle.Controls.Add(this.settingsPanelLabel);
            this.settingsPanelTitle.Location = new System.Drawing.Point(-1, -1);
            this.settingsPanelTitle.Name = "settingsPanelTitle";
            this.settingsPanelTitle.Size = new System.Drawing.Size(541, 57);
            this.settingsPanelTitle.TabIndex = 0;
            // 
            // userPanelLbl
            // 
            this.userPanelLbl.AutoSize = true;
            this.userPanelLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPanelLbl.Location = new System.Drawing.Point(3, 18);
            this.userPanelLbl.Name = "userPanelLbl";
            this.userPanelLbl.Size = new System.Drawing.Size(49, 24);
            this.userPanelLbl.TabIndex = 0;
            this.userPanelLbl.Text = "User";
            this.userPanelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // settingsPanelLabel
            // 
            this.settingsPanelLabel.AutoSize = true;
            this.settingsPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsPanelLabel.Location = new System.Drawing.Point(3, 18);
            this.settingsPanelLabel.Name = "settingsPanelLabel";
            this.settingsPanelLabel.Size = new System.Drawing.Size(76, 24);
            this.settingsPanelLabel.TabIndex = 0;
            this.settingsPanelLabel.Text = "Settings";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(15, 84);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.Text = "Username";
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Location = new System.Drawing.Point(15, 100);
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(196, 20);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(15, 127);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Location = new System.Drawing.Point(15, 144);
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(196, 20);
            this.passwordTxtBox.TabIndex = 4;
            // 
            // confirmPassLbl
            // 
            this.confirmPassLbl.AutoSize = true;
            this.confirmPassLbl.Location = new System.Drawing.Point(15, 167);
            this.confirmPassLbl.Name = "confirmPassLbl";
            this.confirmPassLbl.Size = new System.Drawing.Size(109, 13);
            this.confirmPassLbl.TabIndex = 5;
            this.confirmPassLbl.Text = "Confirm the Password";
            this.confirmPassLbl.Visible = false;
            // 
            // confirmTxtBox
            // 
            this.confirmTxtBox.Enabled = false;
            this.confirmTxtBox.Location = new System.Drawing.Point(15, 183);
            this.confirmTxtBox.Name = "confirmTxtBox";
            this.confirmTxtBox.PasswordChar = '*';
            this.confirmTxtBox.Size = new System.Drawing.Size(196, 20);
            this.confirmTxtBox.TabIndex = 6;
            this.confirmTxtBox.Visible = false;
            // 
            // inviteLbl
            // 
            this.inviteLbl.AutoSize = true;
            this.inviteLbl.Location = new System.Drawing.Point(15, 210);
            this.inviteLbl.Name = "inviteLbl";
            this.inviteLbl.Size = new System.Drawing.Size(76, 13);
            this.inviteLbl.TabIndex = 7;
            this.inviteLbl.Text = "Invite PinCode";
            this.inviteLbl.Visible = false;
            // 
            // inviteTxtBox
            // 
            this.inviteTxtBox.Enabled = false;
            this.inviteTxtBox.Location = new System.Drawing.Point(15, 227);
            this.inviteTxtBox.Name = "inviteTxtBox";
            this.inviteTxtBox.Size = new System.Drawing.Size(196, 20);
            this.inviteTxtBox.TabIndex = 8;
            this.inviteTxtBox.Visible = false;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(15, 269);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(95, 23);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(116, 269);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(95, 23);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // confirmPictBox
            // 
            this.confirmPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.confirm;
            this.confirmPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmPictBox.Location = new System.Drawing.Point(693, -1);
            this.confirmPictBox.Name = "confirmPictBox";
            this.confirmPictBox.Size = new System.Drawing.Size(87, 47);
            this.confirmPictBox.TabIndex = 0;
            this.confirmPictBox.TabStop = false;
            this.confirmPictBox.Click += new System.EventHandler(this.confirmBtnClick);
            // 
            // cancelPictBox
            // 
            this.cancelPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cancel;
            this.cancelPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPictBox.Location = new System.Drawing.Point(630, 3);
            this.cancelPictBox.Name = "cancelPictBox";
            this.cancelPictBox.Size = new System.Drawing.Size(57, 43);
            this.cancelPictBox.TabIndex = 1;
            this.cancelPictBox.TabStop = false;
            this.cancelPictBox.Click += new System.EventHandler(this.cancelBtnClick);
            // 
            // UserSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.settingsPanel);
            this.Controls.Add(this.userPanel);
            this.Name = "UserSettingsForm";
            this.Text = "UserSettingsForm";
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.settingsPanel.ResumeLayout(false);
            this.subPanel.ResumeLayout(false);
            this.userPanelTitle.ResumeLayout(false);
            this.userPanelTitle.PerformLayout();
            this.settingsPanelTitle.ResumeLayout(false);
            this.settingsPanelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Panel userPanelTitle;
        private System.Windows.Forms.Label userPanelLbl;
        private System.Windows.Forms.Panel settingsPanel;
        private System.Windows.Forms.Panel settingsPanelTitle;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TextBox inviteTxtBox;
        private System.Windows.Forms.Label inviteLbl;
        private System.Windows.Forms.TextBox confirmTxtBox;
        private System.Windows.Forms.Label confirmPassLbl;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label settingsPanelLabel;
        private System.Windows.Forms.PictureBox confirmPictBox;
        private System.Windows.Forms.PictureBox cancelPictBox;
    }
}