
namespace CheckListWindows.Forms
{
    partial class ShareForm
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
            this.shareLbl = new System.Windows.Forms.Label();
            this.pincodeLbl = new System.Windows.Forms.Label();
            this.pinCodeValueLbl = new System.Windows.Forms.Label();
            this.sharePanelTitle = new System.Windows.Forms.Panel();
            this.subPanel = new System.Windows.Forms.Panel();
            this.confirmPicBox = new System.Windows.Forms.PictureBox();
            this.sharePanelTitle.SuspendLayout();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shareLbl
            // 
            this.shareLbl.AutoSize = true;
            this.shareLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareLbl.Location = new System.Drawing.Point(3, 3);
            this.shareLbl.Name = "shareLbl";
            this.shareLbl.Size = new System.Drawing.Size(194, 24);
            this.shareLbl.TabIndex = 0;
            this.shareLbl.Text = "Use the code to share";
            // 
            // pincodeLbl
            // 
            this.pincodeLbl.AutoSize = true;
            this.pincodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincodeLbl.Location = new System.Drawing.Point(73, 46);
            this.pincodeLbl.Name = "pincodeLbl";
            this.pincodeLbl.Size = new System.Drawing.Size(88, 24);
            this.pincodeLbl.TabIndex = 2;
            this.pincodeLbl.Text = "Pin Code";
            // 
            // pinCodeValueLbl
            // 
            this.pinCodeValueLbl.AutoSize = true;
            this.pinCodeValueLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pinCodeValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pinCodeValueLbl.Location = new System.Drawing.Point(54, 70);
            this.pinCodeValueLbl.Name = "pinCodeValueLbl";
            this.pinCodeValueLbl.Size = new System.Drawing.Size(123, 35);
            this.pinCodeValueLbl.TabIndex = 3;
            this.pinCodeValueLbl.Text = "123-456";
            // 
            // sharePanelTitle
            // 
            this.sharePanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sharePanelTitle.Controls.Add(this.shareLbl);
            this.sharePanelTitle.Location = new System.Drawing.Point(12, 5);
            this.sharePanelTitle.Name = "sharePanelTitle";
            this.sharePanelTitle.Size = new System.Drawing.Size(207, 38);
            this.sharePanelTitle.TabIndex = 5;
            this.sharePanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeMouseDown);
            this.sharePanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeMouseMove);
            // 
            // subPanel
            // 
            this.subPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPanel.Controls.Add(this.confirmPicBox);
            this.subPanel.Location = new System.Drawing.Point(12, 117);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(207, 54);
            this.subPanel.TabIndex = 6;
            // 
            // confirmPicBox
            // 
            this.confirmPicBox.BackgroundImage = global::CheckListWindows.Properties.Resources.confirm;
            this.confirmPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmPicBox.Location = new System.Drawing.Point(133, -2);
            this.confirmPicBox.Name = "confirmPicBox";
            this.confirmPicBox.Size = new System.Drawing.Size(73, 55);
            this.confirmPicBox.TabIndex = 2;
            this.confirmPicBox.TabStop = false;
            this.confirmPicBox.Click += new System.EventHandler(this.confirmPicBox_Click);
            // 
            // ShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 179);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.sharePanelTitle);
            this.Controls.Add(this.pinCodeValueLbl);
            this.Controls.Add(this.pincodeLbl);
            this.Name = "ShareForm";
            this.Text = "ShareForm";
            this.sharePanelTitle.ResumeLayout(false);
            this.sharePanelTitle.PerformLayout();
            this.subPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.confirmPicBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shareLbl;
        private System.Windows.Forms.Label pincodeLbl;
        private System.Windows.Forms.Label pinCodeValueLbl;
        private System.Windows.Forms.Panel sharePanelTitle;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.PictureBox confirmPicBox;
    }
}