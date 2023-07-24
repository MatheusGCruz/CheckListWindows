
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
            this.label1 = new System.Windows.Forms.Label();
            this.selectorComboBox = new System.Windows.Forms.ComboBox();
            this.sharePanelTitle = new System.Windows.Forms.Panel();
            this.subPanel = new System.Windows.Forms.Panel();
            this.cancelPictBox = new System.Windows.Forms.PictureBox();
            this.sharePictBox = new System.Windows.Forms.PictureBox();
            this.sharePanelTitle.SuspendLayout();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePictBox)).BeginInit();
            this.SuspendLayout();
            // 
            // shareLbl
            // 
            this.shareLbl.AutoSize = true;
            this.shareLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shareLbl.Location = new System.Drawing.Point(64, 13);
            this.shareLbl.Name = "shareLbl";
            this.shareLbl.Size = new System.Drawing.Size(169, 24);
            this.shareLbl.TabIndex = 0;
            this.shareLbl.Text = "Select List to Share";
            // 
            // pincodeLbl
            // 
            this.pincodeLbl.AutoSize = true;
            this.pincodeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pincodeLbl.Location = new System.Drawing.Point(112, 118);
            this.pincodeLbl.Name = "pincodeLbl";
            this.pincodeLbl.Size = new System.Drawing.Size(88, 24);
            this.pincodeLbl.TabIndex = 2;
            this.pincodeLbl.Text = "Pin Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "123-456";
            // 
            // selectorComboBox
            // 
            this.selectorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectorComboBox.FormattingEnabled = true;
            this.selectorComboBox.Location = new System.Drawing.Point(12, 58);
            this.selectorComboBox.Name = "selectorComboBox";
            this.selectorComboBox.Size = new System.Drawing.Size(305, 32);
            this.selectorComboBox.TabIndex = 4;
            // 
            // sharePanelTitle
            // 
            this.sharePanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sharePanelTitle.Controls.Add(this.shareLbl);
            this.sharePanelTitle.Location = new System.Drawing.Point(12, 5);
            this.sharePanelTitle.Name = "sharePanelTitle";
            this.sharePanelTitle.Size = new System.Drawing.Size(305, 47);
            this.sharePanelTitle.TabIndex = 5;
            this.sharePanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeMouseDown);
            this.sharePanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeMouseMove);
            // 
            // subPanel
            // 
            this.subPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPanel.Controls.Add(this.sharePictBox);
            this.subPanel.Controls.Add(this.cancelPictBox);
            this.subPanel.Location = new System.Drawing.Point(12, 214);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(305, 54);
            this.subPanel.TabIndex = 6;
            // 
            // cancelPictBox
            // 
            this.cancelPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cancel;
            this.cancelPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPictBox.Location = new System.Drawing.Point(234, -1);
            this.cancelPictBox.Name = "cancelPictBox";
            this.cancelPictBox.Size = new System.Drawing.Size(71, 55);
            this.cancelPictBox.TabIndex = 0;
            this.cancelPictBox.TabStop = false;
            this.cancelPictBox.Click += new System.EventHandler(this.cancelClick);
            // 
            // sharePictBox
            // 
            this.sharePictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.share;
            this.sharePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sharePictBox.Location = new System.Drawing.Point(-1, -1);
            this.sharePictBox.Name = "sharePictBox";
            this.sharePictBox.Size = new System.Drawing.Size(85, 55);
            this.sharePictBox.TabIndex = 1;
            this.sharePictBox.TabStop = false;
            this.sharePictBox.Click += new System.EventHandler(this.shareClick);
            // 
            // ShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 283);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.sharePanelTitle);
            this.Controls.Add(this.selectorComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pincodeLbl);
            this.Name = "ShareForm";
            this.Text = "ShareForm";
            this.sharePanelTitle.ResumeLayout(false);
            this.sharePanelTitle.PerformLayout();
            this.subPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shareLbl;
        private System.Windows.Forms.Label pincodeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox selectorComboBox;
        private System.Windows.Forms.Panel sharePanelTitle;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.PictureBox sharePictBox;
        private System.Windows.Forms.PictureBox cancelPictBox;
    }
}