
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
            this.listCombo = new System.Windows.Forms.ComboBox();
            this.sharePanelTitle = new System.Windows.Forms.Panel();
            this.subPanel = new System.Windows.Forms.Panel();
            this.listRadio = new System.Windows.Forms.RadioButton();
            this.itemRadio = new System.Windows.Forms.RadioButton();
            this.insertTxtbox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.confirmPicBox = new System.Windows.Forms.PictureBox();
            this.sharePictBox = new System.Windows.Forms.PictureBox();
            this.cancelPictBox = new System.Windows.Forms.PictureBox();
            this.itensCombo = new System.Windows.Forms.ComboBox();
            this.sharePanelTitle.SuspendLayout();
            this.subPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictBox)).BeginInit();
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
            this.pincodeLbl.Location = new System.Drawing.Point(158, 172);
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
            this.label1.Location = new System.Drawing.Point(252, 164);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 35);
            this.label1.TabIndex = 3;
            this.label1.Text = "123-456";
            // 
            // listCombo
            // 
            this.listCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCombo.FormattingEnabled = true;
            this.listCombo.Location = new System.Drawing.Point(12, 58);
            this.listCombo.Name = "listCombo";
            this.listCombo.Size = new System.Drawing.Size(471, 32);
            this.listCombo.TabIndex = 4;
            // 
            // sharePanelTitle
            // 
            this.sharePanelTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sharePanelTitle.Controls.Add(this.shareLbl);
            this.sharePanelTitle.Location = new System.Drawing.Point(12, 5);
            this.sharePanelTitle.Name = "sharePanelTitle";
            this.sharePanelTitle.Size = new System.Drawing.Size(471, 47);
            this.sharePanelTitle.TabIndex = 5;
            this.sharePanelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeMouseDown);
            this.sharePanelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeMouseMove);
            // 
            // subPanel
            // 
            this.subPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subPanel.Controls.Add(this.pictureBox2);
            this.subPanel.Controls.Add(this.confirmPicBox);
            this.subPanel.Controls.Add(this.sharePictBox);
            this.subPanel.Controls.Add(this.cancelPictBox);
            this.subPanel.Location = new System.Drawing.Point(12, 214);
            this.subPanel.Name = "subPanel";
            this.subPanel.Size = new System.Drawing.Size(471, 54);
            this.subPanel.TabIndex = 6;
            // 
            // listRadio
            // 
            this.listRadio.AutoSize = true;
            this.listRadio.Location = new System.Drawing.Point(12, 175);
            this.listRadio.Name = "listRadio";
            this.listRadio.Size = new System.Drawing.Size(41, 17);
            this.listRadio.TabIndex = 7;
            this.listRadio.TabStop = true;
            this.listRadio.Text = "List";
            this.listRadio.UseVisualStyleBackColor = true;
            // 
            // itemRadio
            // 
            this.itemRadio.AutoSize = true;
            this.itemRadio.Location = new System.Drawing.Point(59, 175);
            this.itemRadio.Name = "itemRadio";
            this.itemRadio.Size = new System.Drawing.Size(45, 17);
            this.itemRadio.TabIndex = 8;
            this.itemRadio.TabStop = true;
            this.itemRadio.Text = "Item";
            this.itemRadio.UseVisualStyleBackColor = true;
            // 
            // insertTxtbox
            // 
            this.insertTxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertTxtbox.Location = new System.Drawing.Point(12, 132);
            this.insertTxtbox.Name = "insertTxtbox";
            this.insertTxtbox.Size = new System.Drawing.Size(470, 26);
            this.insertTxtbox.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::CheckListWindows.Properties.Resources.trash;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 55);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // confirmPicBox
            // 
            this.confirmPicBox.BackgroundImage = global::CheckListWindows.Properties.Resources.confirm;
            this.confirmPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmPicBox.Location = new System.Drawing.Point(397, -1);
            this.confirmPicBox.Name = "confirmPicBox";
            this.confirmPicBox.Size = new System.Drawing.Size(73, 55);
            this.confirmPicBox.TabIndex = 2;
            this.confirmPicBox.TabStop = false;
            // 
            // sharePictBox
            // 
            this.sharePictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.share;
            this.sharePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sharePictBox.Location = new System.Drawing.Point(69, -1);
            this.sharePictBox.Name = "sharePictBox";
            this.sharePictBox.Size = new System.Drawing.Size(81, 55);
            this.sharePictBox.TabIndex = 1;
            this.sharePictBox.TabStop = false;
            this.sharePictBox.Click += new System.EventHandler(this.shareClick);
            // 
            // cancelPictBox
            // 
            this.cancelPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cancel;
            this.cancelPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPictBox.Location = new System.Drawing.Point(320, -2);
            this.cancelPictBox.Name = "cancelPictBox";
            this.cancelPictBox.Size = new System.Drawing.Size(71, 55);
            this.cancelPictBox.TabIndex = 0;
            this.cancelPictBox.TabStop = false;
            this.cancelPictBox.Click += new System.EventHandler(this.cancelClick);
            // 
            // itensCombo
            // 
            this.itensCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itensCombo.FormattingEnabled = true;
            this.itensCombo.Location = new System.Drawing.Point(12, 94);
            this.itensCombo.Name = "itensCombo";
            this.itensCombo.Size = new System.Drawing.Size(471, 32);
            this.itensCombo.TabIndex = 10;
            // 
            // ShareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 283);
            this.Controls.Add(this.itensCombo);
            this.Controls.Add(this.insertTxtbox);
            this.Controls.Add(this.itemRadio);
            this.Controls.Add(this.listRadio);
            this.Controls.Add(this.subPanel);
            this.Controls.Add(this.sharePanelTitle);
            this.Controls.Add(this.listCombo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pincodeLbl);
            this.Name = "ShareForm";
            this.Text = "ShareForm";
            this.sharePanelTitle.ResumeLayout(false);
            this.sharePanelTitle.PerformLayout();
            this.subPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sharePictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPictBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shareLbl;
        private System.Windows.Forms.Label pincodeLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listCombo;
        private System.Windows.Forms.Panel sharePanelTitle;
        private System.Windows.Forms.Panel subPanel;
        private System.Windows.Forms.PictureBox sharePictBox;
        private System.Windows.Forms.PictureBox cancelPictBox;
        private System.Windows.Forms.PictureBox confirmPicBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton listRadio;
        private System.Windows.Forms.RadioButton itemRadio;
        private System.Windows.Forms.TextBox insertTxtbox;
        private System.Windows.Forms.ComboBox itensCombo;
    }
}