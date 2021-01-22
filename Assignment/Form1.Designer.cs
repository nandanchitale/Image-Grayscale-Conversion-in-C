
using System;

namespace Assignment
{
    partial class frmImageConversion
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGray = new System.Windows.Forms.Label();
            this.imgGray = new System.Windows.Forms.PictureBox();
            this.lbltracker = new System.Windows.Forms.Label();
            this.imgUpload = new System.Windows.Forms.PictureBox();
            this.trkToGray = new System.Windows.Forms.TrackBar();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkToGray)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Location = new System.Drawing.Point(86, 273);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(203, 57);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(618, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // lblGray
            // 
            this.lblGray.AutoSize = true;
            this.lblGray.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblGray.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGray.Location = new System.Drawing.Point(534, 289);
            this.lblGray.Name = "lblGray";
            this.lblGray.Size = new System.Drawing.Size(180, 24);
            this.lblGray.TabIndex = 2;
            this.lblGray.Text = "GrayScaled Image";
            // 
            // imgGray
            // 
            this.imgGray.Location = new System.Drawing.Point(438, 12);
            this.imgGray.Name = "imgGray";
            this.imgGray.Size = new System.Drawing.Size(350, 250);
            this.imgGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGray.TabIndex = 3;
            this.imgGray.TabStop = false;
            // 
            // lbltracker
            // 
            this.lbltracker.AutoSize = true;
            this.lbltracker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltracker.Location = new System.Drawing.Point(497, 289);
            this.lbltracker.Name = "lbltracker";
            this.lbltracker.Size = new System.Drawing.Size(40, 24);
            this.lbltracker.TabIndex = 4;
            this.lbltracker.Text = "0 %";
            // 
            // imgUpload
            // 
            this.imgUpload.Location = new System.Drawing.Point(12, 12);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(350, 250);
            this.imgUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpload.TabIndex = 5;
            this.imgUpload.TabStop = false;
            // 
            // trkToGray
            // 
            this.trkToGray.Enabled = false;
            this.trkToGray.Location = new System.Drawing.Point(12, 359);
            this.trkToGray.Maximum = 255;
            this.trkToGray.Name = "trkToGray";
            this.trkToGray.Size = new System.Drawing.Size(776, 45);
            this.trkToGray.TabIndex = 6;
            this.trkToGray.Scroll += new System.EventHandler(this.TrkToGray_Scroll);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(391, 417);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(251, 13);
            this.lblInfo.TabIndex = 7;
            this.lblInfo.Text = "Use the slider to convert image into black and white";
            // 
            // frmImageConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.trkToGray);
            this.Controls.Add(this.imgUpload);
            this.Controls.Add(this.lbltracker);
            this.Controls.Add(this.imgGray);
            this.Controls.Add(this.lblGray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpload);
            this.Name = "frmImageConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Conversion";
            ((System.ComponentModel.ISupportInitialize)(this.imgGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkToGray)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGray;
        private System.Windows.Forms.PictureBox imgGray;
        private System.Windows.Forms.Label lbltracker;
        private System.Windows.Forms.PictureBox imgUpload;
        private System.Windows.Forms.TrackBar trkToGray;
        private System.Windows.Forms.Label lblInfo;

        public EventHandler trkToGray_Scroll { get; private set; }
    }
}

