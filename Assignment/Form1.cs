using System;
using System.Drawing;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Assignment
{
    public partial class frmImageConversion : Form
    {
        private Image<Gray, Byte> img;
        string fileLoc;

        public frmImageConversion()
        {
            InitializeComponent();
        }

        private void BtnUpload_click(object sender, EventArgs e)
        {
            // Open file dialog with image filters
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    fileLoc = ofd.FileName;

                    img = new Image<Gray, Byte>(fileLoc);
                    
                    // Display Uploaded Image
                    imgUpload.Image = new Bitmap(fileLoc);

                    trkToGray.Enabled = true;
                    
                }
            }
        }

        private void TrkToGray_Scroll(object sender, EventArgs e)
        {
            double trackbar = trkToGray.Value;
            int lblVal;

            if (fileLoc != null)
            {
                using (Image<Gray, Byte> Gray = img.ThresholdBinary(new Gray(trackbar), new Gray(255)))
                {

                    lblVal = (int)trackbar;
                    
                    // Display % conversion
                    lbltracker.Text = " " + lblVal * 100 / 255 + " % "; 

                    // Display Converted Image
                    imgGray.Image = Gray.ToBitmap();
                }
            }
        }

    }
}