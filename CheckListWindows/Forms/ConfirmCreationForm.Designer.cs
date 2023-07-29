
namespace CheckListWindows.Forms
{
    partial class ConfirmCreationForm
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
            this.descLbl = new System.Windows.Forms.Label();
            this.itemDescLbl = new System.Windows.Forms.Label();
            this.cancelPicBox = new System.Windows.Forms.PictureBox();
            this.confirmPictBox = new System.Windows.Forms.PictureBox();
            this.cyclePictBox = new System.Windows.Forms.PictureBox();
            this.defaultPnl = new System.Windows.Forms.Panel();
            this.controlPnl = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPictBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclePictBox)).BeginInit();
            this.defaultPnl.SuspendLayout();
            this.controlPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // descLbl
            // 
            this.descLbl.AutoSize = true;
            this.descLbl.Enabled = false;
            this.descLbl.Location = new System.Drawing.Point(11, 17);
            this.descLbl.Name = "descLbl";
            this.descLbl.Size = new System.Drawing.Size(54, 13);
            this.descLbl.TabIndex = 0;
            this.descLbl.Text = "New item:";
            // 
            // itemDescLbl
            // 
            this.itemDescLbl.AutoSize = true;
            this.itemDescLbl.Location = new System.Drawing.Point(3, 66);
            this.itemDescLbl.Name = "itemDescLbl";
            this.itemDescLbl.Size = new System.Drawing.Size(77, 13);
            this.itemDescLbl.TabIndex = 1;
            this.itemDescLbl.Text = "new item Desc";
            // 
            // cancelPicBox
            // 
            this.cancelPicBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cancel;
            this.cancelPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelPicBox.Location = new System.Drawing.Point(136, 130);
            this.cancelPicBox.Name = "cancelPicBox";
            this.cancelPicBox.Size = new System.Drawing.Size(54, 41);
            this.cancelPicBox.TabIndex = 4;
            this.cancelPicBox.TabStop = false;
            this.cancelPicBox.Click += new System.EventHandler(this.cancelPicBox_Click);
            // 
            // confirmPictBox
            // 
            this.confirmPictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.confirm;
            this.confirmPictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.confirmPictBox.Location = new System.Drawing.Point(196, 130);
            this.confirmPictBox.Name = "confirmPictBox";
            this.confirmPictBox.Size = new System.Drawing.Size(54, 41);
            this.confirmPictBox.TabIndex = 3;
            this.confirmPictBox.TabStop = false;
            this.confirmPictBox.Click += new System.EventHandler(this.confirmPictBox_Click);
            // 
            // cyclePictBox
            // 
            this.cyclePictBox.BackgroundImage = global::CheckListWindows.Properties.Resources.cycle;
            this.cyclePictBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cyclePictBox.Enabled = false;
            this.cyclePictBox.Location = new System.Drawing.Point(6, 130);
            this.cyclePictBox.Name = "cyclePictBox";
            this.cyclePictBox.Size = new System.Drawing.Size(54, 41);
            this.cyclePictBox.TabIndex = 2;
            this.cyclePictBox.TabStop = false;
            this.cyclePictBox.Visible = false;
            // 
            // defaultPnl
            // 
            this.defaultPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.defaultPnl.Controls.Add(this.controlPnl);
            this.defaultPnl.Controls.Add(this.confirmPictBox);
            this.defaultPnl.Controls.Add(this.cancelPicBox);
            this.defaultPnl.Controls.Add(this.itemDescLbl);
            this.defaultPnl.Controls.Add(this.cyclePictBox);
            this.defaultPnl.Location = new System.Drawing.Point(12, 13);
            this.defaultPnl.Name = "defaultPnl";
            this.defaultPnl.Size = new System.Drawing.Size(269, 182);
            this.defaultPnl.TabIndex = 5;
            // 
            // controlPnl
            // 
            this.controlPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.controlPnl.Controls.Add(this.descLbl);
            this.controlPnl.Location = new System.Drawing.Point(4, 4);
            this.controlPnl.Name = "controlPnl";
            this.controlPnl.Size = new System.Drawing.Size(258, 50);
            this.controlPnl.TabIndex = 5;
            // 
            // ConfirmCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 202);
            this.Controls.Add(this.defaultPnl);
            this.Name = "ConfirmCreationForm";
            this.Text = "ConfirmCreationForm";
            this.Load += new System.EventHandler(this.ConfirmCreationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPictBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cyclePictBox)).EndInit();
            this.defaultPnl.ResumeLayout(false);
            this.defaultPnl.PerformLayout();
            this.controlPnl.ResumeLayout(false);
            this.controlPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label descLbl;
        private System.Windows.Forms.Label itemDescLbl;
        private System.Windows.Forms.PictureBox cyclePictBox;
        private System.Windows.Forms.PictureBox confirmPictBox;
        private System.Windows.Forms.PictureBox cancelPicBox;
        private System.Windows.Forms.Panel defaultPnl;
        private System.Windows.Forms.Panel controlPnl;
    }
}