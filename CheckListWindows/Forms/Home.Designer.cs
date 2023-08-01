
namespace CheckListWindows
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.listItensPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.refreshPictBox = new System.Windows.Forms.PictureBox();
            this.connPictBox = new System.Windows.Forms.PictureBox();
            this.pinPictBox = new System.Windows.Forms.PictureBox();
            this.subPanel = new System.Windows.Forms.Panel();
            this.confirmPicBox = new System.Windows.Forms.PictureBox();
            this.cancelPicBox = new System.Windows.Forms.PictureBox();
            this.trashPicBox = new System.Windows.Forms.PictureBox();
            this.sharePictBox = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.shadowRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.listRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.checklistIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.connPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPictBox)).BeginInit();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // listItensPanel
            // 
            this.listItensPanel.AutoSize = true;
            this.listItensPanel.BackColor = System.Drawing.SystemColors.Info;
            this.listItensPanel.Location = new System.Drawing.Point(12, 68);
            this.listItensPanel.Name = "listItensPanel";
            this.listItensPanel.Size = new System.Drawing.Size(303, 500);
            this.listItensPanel.TabIndex = 4;
            // 
            // titlePanel
            // 
            this.titlePanel.Controls.Add(this.refreshPictBox);
            this.titlePanel.Controls.Add(this.connPictBox);
            this.titlePanel.Controls.Add(this.pinPictBox);
            this.titlePanel.Location = new System.Drawing.Point(13, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(302, 50);
            this.titlePanel.TabIndex = 7;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeMouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeMouseMove);
            // 
            // refreshPictBox
            // 
            this.refreshPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cycle;
            this.refreshPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshPictBox.Enabled = false;
            this.refreshPictBox.Location = new System.Drawing.Point(72, 4);
            this.refreshPictBox.Name = "refreshPictBox";
            this.refreshPictBox.Size = new System.Drawing.Size(62, 43);
            this.refreshPictBox.TabIndex = 8;
            this.refreshPictBox.TabStop = false;
            this.refreshPictBox.Visible = false;
            // 
            // connPictBox
            // 
            this.connPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.wifi_white;
            this.connPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.connPictBox.Location = new System.Drawing.Point(3, 3);
            this.connPictBox.Name = "connPictBox";
            this.connPictBox.Size = new System.Drawing.Size(62, 44);
            this.connPictBox.TabIndex = 7;
            this.connPictBox.TabStop = false;
            this.connPictBox.Click += new System.EventHandler(this.refreshConnection);
            // 
            // pinPictBox
            // 
            this.pinPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.pin_white;
            this.pinPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pinPictBox.Image = global::CheckListWindows.Properties.Resources.pin_white;
            this.pinPictBox.Location = new System.Drawing.Point(202, 3);
            this.pinPictBox.Name = "pinPictBox";
            this.pinPictBox.Size = new System.Drawing.Size(100, 50);
            this.pinPictBox.TabIndex = 6;
            this.pinPictBox.TabStop = false;
            this.pinPictBox.Click += new System.EventHandler(this.pinBtn_Click);
            // 
            // subPanel
            // 
            this.subPanel.Controls.Add(this.confirmPicBox);
            this.subPanel.Controls.Add(this.cancelPicBox);
            this.subPanel.Controls.Add(this.trashPicBox);
            this.subPanel.Controls.Add(this.sharePictBox);
            this.subPanel.Controls.Add(this.settingsBtn);
            this.subPanel.Location = new System.Drawing.Point(12, 569);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(302, 42);
            this.subPanel.TabIndex = 8;
            // 
            // confirmPicBox
            // 
            this.confirmPicBox.BackgroundImage = global::CheckListWindows.Properties.Resources.confirm;
            this.confirmPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmPicBox.Enabled = false;
            this.confirmPicBox.Location = new System.Drawing.Point(190, 0);
            this.confirmPicBox.Name = "confirmPicBox";
            this.confirmPicBox.Size = new System.Drawing.Size(49, 42);
            this.confirmPicBox.TabIndex = 4;
            this.confirmPicBox.TabStop = false;
            this.confirmPicBox.Visible = false;
            this.confirmPicBox.Click += new System.EventHandler(this.confirmPicBox_Click);
            // 
            // cancelPicBox
            // 
            this.cancelPicBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cancel;
            this.cancelPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPicBox.Enabled = false;
            this.cancelPicBox.Location = new System.Drawing.Point(133, 0);
            this.cancelPicBox.Name = "cancelPicBox";
            this.cancelPicBox.Size = new System.Drawing.Size(50, 42);
            this.cancelPicBox.TabIndex = 3;
            this.cancelPicBox.TabStop = false;
            this.cancelPicBox.Visible = false;
            this.cancelPicBox.Click += new System.EventHandler(this.cancelPicBox_Click);
            // 
            // trashPicBox
            // 
            this.trashPicBox.BackgroundImage = global::CheckListWindows.Properties.Resources.trash;
            this.trashPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.trashPicBox.Enabled = false;
            this.trashPicBox.Location = new System.Drawing.Point(72, 0);
            this.trashPicBox.Name = "trashPicBox";
            this.trashPicBox.Size = new System.Drawing.Size(55, 42);
            this.trashPicBox.TabIndex = 2;
            this.trashPicBox.TabStop = false;
            this.trashPicBox.Visible = false;
            this.trashPicBox.Click += new System.EventHandler(this.trashPicBox_Click);
            // 
            // sharePictBox
            // 
            this.sharePictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.share;
            this.sharePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sharePictBox.Enabled = false;
            this.sharePictBox.Location = new System.Drawing.Point(0, 4);
            this.sharePictBox.Name = "sharePictBox";
            this.sharePictBox.Size = new System.Drawing.Size(66, 38);
            this.sharePictBox.TabIndex = 1;
            this.sharePictBox.TabStop = false;
            this.sharePictBox.Visible = false;
            this.sharePictBox.Click += new System.EventHandler(this.shareClick);
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackgroundImage = global::CheckListWindows.Properties.Resources.wrench;
            this.settingsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsBtn.Location = new System.Drawing.Point(254, 0);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(49, 42);
            this.settingsBtn.TabIndex = 0;
            this.settingsBtn.TabStop = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // shadowRefreshTimer
            // 
            this.shadowRefreshTimer.Tick += new System.EventHandler(this.shadowRefreshTimer_Tick);
            // 
            // listRefreshTimer
            // 
            this.listRefreshTimer.Tick += new System.EventHandler(this.listRefreshTimer_Tick);
            // 
            // checklistIcon
            // 
            this.checklistIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.checklistIcon.BalloonTipText = "Open Checklist App";
            this.checklistIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("checklistIcon.Icon")));
            this.checklistIcon.Text = "Check List App";
            this.checklistIcon.Visible = true;
            this.checklistIcon.DoubleClick += new System.EventHandler(this.checklistIcon_DoubleClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(326, 612);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.titlePanel);
            this.Controls.Add(this.listItensPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Home";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeMouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeMouseMove);
            this.titlePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.refreshPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.connPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPictBox)).EndInit();
            this.subPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.confirmPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trashPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel listItensPanel;
        private System.Windows.Forms.PictureBox pinPictBox;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox connPictBox;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.PictureBox settingsBtn;
        private System.Windows.Forms.PictureBox sharePictBox;
        private System.Windows.Forms.Timer shadowRefreshTimer;
        private System.Windows.Forms.Timer listRefreshTimer;
        private System.Windows.Forms.PictureBox refreshPictBox;
        private System.Windows.Forms.PictureBox confirmPicBox;
        private System.Windows.Forms.PictureBox cancelPicBox;
        private System.Windows.Forms.PictureBox trashPicBox;
        private System.Windows.Forms.NotifyIcon checklistIcon;
    }
}

