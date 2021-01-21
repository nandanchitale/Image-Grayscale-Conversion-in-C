using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;

namespace Assignment
{
    public partial class frmImageConversion : Form
    {
        public frmImageConversion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Open file dialog with image filters
            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileLoc = ofd.FileName;
                    Mat img = CvInvoke.Imread(fileLoc);

                    // Displaying Uploaded Image 
                    imgUpload.Image = new Bitmap(ofd.FileName);
                    
                    // Converting Image into Grayscale
                    Image<Bgr, byte> inputImage = img.ToImage<Bgr, byte>();
                    Image<Gray, Byte> result = inputImage.Convert<Gray, Byte>();

                    // Displaying Grayscaled Image in Picture Box
                    imgGrayscale.Image = new Bitmap(result.ToBitmap());
                }
            }
        }
    }
}
