
namespace CheckListWindows
{
    partial class Login
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
            this.loginBtn = new System.Windows.Forms.Button();
            this.userTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.confirmPasswordLbl = new System.Windows.Forms.Label();
            this.confirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.inviteLbl = new System.Windows.Forms.Label();
            this.inviteTxt = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(99, 213);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 0;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(12, 70);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(162, 20);
            this.userTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(12, 109);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(162, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Location = new System.Drawing.Point(9, 54);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(57, 13);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "UserName";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(9, 93);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 4;
            this.passwordLbl.Text = "Password";
            // 
            // confirmPasswordLbl
            // 
            this.confirmPasswordLbl.AutoSize = true;
            this.confirmPasswordLbl.Enabled = false;
            this.confirmPasswordLbl.Location = new System.Drawing.Point(9, 132);
            this.confirmPasswordLbl.Name = "confirmPasswordLbl";
            this.confirmPasswordLbl.Size = new System.Drawing.Size(90, 13);
            this.confirmPasswordLbl.TabIndex = 6;
            this.confirmPasswordLbl.Text = "Retype Password";
            this.confirmPasswordLbl.Visible = false;
            // 
            // confirmPasswordTxt
            // 
            this.confirmPasswordTxt.Enabled = false;
            this.confirmPasswordTxt.Location = new System.Drawing.Point(12, 148);
            this.confirmPasswordTxt.Name = "confirmPasswordTxt";
            this.confirmPasswordTxt.PasswordChar = '*';
            this.confirmPasswordTxt.Size = new System.Drawing.Size(162, 20);
            this.confirmPasswordTxt.TabIndex = 5;
            // 
            // inviteLbl
            // 
            this.inviteLbl.AutoSize = true;
            this.inviteLbl.Location = new System.Drawing.Point(9, 171);
            this.inviteLbl.Name = "inviteLbl";
            this.inviteLbl.Size = new System.Drawing.Size(33, 13);
            this.inviteLbl.TabIndex = 8;
            this.inviteLbl.Text = "Invite";
            // 
            // inviteTxt
            // 
            this.inviteTxt.Enabled = false;
            this.inviteTxt.Location = new System.Drawing.Point(12, 187);
            this.inviteTxt.Name = "inviteTxt";
            this.inviteTxt.Size = new System.Drawing.Size(162, 20);
            this.inviteTxt.TabIndex = 7;
            this.inviteTxt.Visible = false;
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(12, 213);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(75, 23);
            this.registerBtn.TabIndex = 9;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(12, 13);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(0, 13);
            this.messageLabel.TabIndex = 10;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(189, 241);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.inviteLbl);
            this.Controls.Add(this.inviteTxt);
            this.Controls.Add(this.confirmPasswordLbl);
            this.Controls.Add(this.confirmPasswordTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userTxt);
            this.Controls.Add(this.loginBtn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox userTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label confirmPasswordLbl;
        private System.Windows.Forms.TextBox confirmPasswordTxt;
        private System.Windows.Forms.Label inviteLbl;
        private System.Windows.Forms.TextBox inviteTxt;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label messageLabel;
    }
}