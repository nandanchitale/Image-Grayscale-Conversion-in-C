
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
            this.btnImageUpload = new System.Windows.Forms.Button();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.grpImages = new System.Windows.Forms.GroupBox();
            this.imgUpload = new System.Windows.Forms.PictureBox();
            this.imgGrayscale = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrayscale)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImageUpload
            // 
            this.btnImageUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnImageUpload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnImageUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImageUpload.Location = new System.Drawing.Point(115, 240);
            this.btnImageUpload.Name = "btnImageUpload";
            this.btnImageUpload.Size = new System.Drawing.Size(177, 41);
            this.btnImageUpload.TabIndex = 1;
            this.btnImageUpload.Text = "Upload Image";
            this.btnImageUpload.UseVisualStyleBackColor = false;
            this.btnImageUpload.Click += new System.EventHandler(this.button1_Click);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(12, 422);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(776, 19);
            this.hScrollBar1.TabIndex = 3;
            // 
            // grpImages
            // 
            this.grpImages.Controls.Add(this.label2);
            this.grpImages.Controls.Add(this.btnImageUpload);
            this.grpImages.Controls.Add(this.imgGrayscale);
            this.grpImages.Controls.Add(this.imgUpload);
            this.grpImages.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpImages.Location = new System.Drawing.Point(0, 0);
            this.grpImages.Name = "grpImages";
            this.grpImages.Size = new System.Drawing.Size(800, 300);
            this.grpImages.TabIndex = 4;
            this.grpImages.TabStop = false;
            // 
            // imgUpload
            // 
            this.imgUpload.Location = new System.Drawing.Point(47, 19);
            this.imgUpload.Name = "imgUpload";
            this.imgUpload.Size = new System.Drawing.Size(314, 214);
            this.imgUpload.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgUpload.TabIndex = 0;
            this.imgUpload.TabStop = false;
            // 
            // imgGrayscale
            // 
            this.imgGrayscale.Location = new System.Drawing.Point(435, 19);
            this.imgGrayscale.Name = "imgGrayscale";
            this.imgGrayscale.Size = new System.Drawing.Size(314, 214);
            this.imgGrayscale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgGrayscale.TabIndex = 1;
            this.imgGrayscale.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(512, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Grayscaled Image";
            // 
            // frmImageConversion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpImages);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "frmImageConversion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Conversion";
            this.grpImages.ResumeLayout(false);
            this.grpImages.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpload)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGrayscale)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImageUpload;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.GroupBox grpImages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox imgGrayscale;
        private System.Windows.Forms.PictureBox imgUpload;
    }
}

