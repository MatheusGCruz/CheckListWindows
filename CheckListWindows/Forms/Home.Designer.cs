
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
            this.listItensPanel = new System.Windows.Forms.Panel();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.connPictBox = new System.Windows.Forms.PictureBox();
            this.pinPictBox = new System.Windows.Forms.PictureBox();
            this.subPanel = new System.Windows.Forms.Panel();
            this.sharePictBox = new System.Windows.Forms.PictureBox();
            this.settingsBtn = new System.Windows.Forms.PictureBox();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.connPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPictBox)).BeginInit();
            this.subPanel.SuspendLayout();
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
            this.titlePanel.Controls.Add(this.connPictBox);
            this.titlePanel.Controls.Add(this.pinPictBox);
            this.titlePanel.Location = new System.Drawing.Point(13, 12);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(302, 50);
            this.titlePanel.TabIndex = 7;
            this.titlePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeMouseDown);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeMouseMove);
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
            this.subPanel.Controls.Add(this.sharePictBox);
            this.subPanel.Controls.Add(this.settingsBtn);
            this.subPanel.Location = new System.Drawing.Point(12, 569);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(302, 42);
            this.subPanel.TabIndex = 8;
            // 
            // sharePictBox
            // 
            this.sharePictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.share;
            this.sharePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sharePictBox.Location = new System.Drawing.Point(0, 4);
            this.sharePictBox.Name = "sharePictBox";
            this.sharePictBox.Size = new System.Drawing.Size(66, 38);
            this.sharePictBox.TabIndex = 1;
            this.sharePictBox.TabStop = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.connPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pinPictBox)).EndInit();
            this.subPanel.ResumeLayout(false);
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
    }
}

