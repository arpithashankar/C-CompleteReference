using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace HarrisCornerDetector
{
    class Program
    {
        private static object myPictureBox;

        static void Main(string[] args)
        {
            Image myImage = Image.FromFile(@"E:\C-CompleteReference\HarrisCornerDetector\charvi.jpg");
            
            myPictureBox.Image  = myImage;
        }
       
    private void ImageExampleForm_Paint(object sender, PaintEventArgs e)
        {
            // Create image.
            Image newImage = Image.FromFile("charvi.jpg");

            // Create Point for upper-left corner of image.
            Point ulCorner = new Point(100, 100);

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, ulCorner);
        }
    
    }
}
