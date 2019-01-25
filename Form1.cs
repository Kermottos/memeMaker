using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace memeMaker
{
    public partial class Form1 : Form
    {
        OpenFileDialog openImage;
        string imageFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void topMemeLabel_TextChanged(object sender, EventArgs e)
        {
            topText.Text = topMemeLabel.Text;
            topLabel.MaximumSize = new Size(pictureBox1.Width, 200);
        }

        private void bottomMemeLabel_TextChanged(object sender, EventArgs e)
        {
            bottomLabel.Text = bottomMemeLabel.Text;
            bottomLabel.MaximumSize = new Size(pictureBox1.Width, 200);
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openImage = new OpenFileDialog();
            openImage.InitialDirectory = "c:\\";
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif; *.bmp";
            openImage.FilterIndex = 2;
            openImage.RestoreDirectory = true;

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(openImage.FileName);
                    imageFile = openImage.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string firstText = topText.Text;
            string secondText = bottomText.Text;

            Bitmap bitmap = (Bitmap)Image.FromFile(imageFile);

            RectangleF TopSize = new RectangleF(0, 10, bitmap.Width, 400);
            RectangleF BottomSize = new RectangleF(0, bitmap.Height - 100, bitmap.Width, 400);

            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.FileName = "*";
            saveImage.DefaultExt = "bmp";
            saveImage.ValidateNames = true;
            saveImage.Filter = "Bitmap Image (.bmp) |*.bmp|Gif Image (.gif)|*.gif |JPEG Image (.jpg)|*.jpeg |Png Image (.png)|*.png";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font memeFont = new Font("Impact", 24, FontStyle.Bold, GraphicsUnit.Point))
                    {
                        graphics.DrawString(firstText, memeFont, Brushes.White, TopSize);
                        graphics.DrawString(secondText, memeFont, Brushes.White, BottomSize);
                    }
                }
                bitmap.Save(saveImage.FileName);
            }
        }
    }
}
