using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPImageEditor
{
    public partial class MainForm : Form
    {
        private Bitmap sourceImage;
        public MainForm()
        {
            InitializeComponent();
            pictureBox.Visible = false;
            imageMenuItem.Visible = false;
        }

        private void openFileMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Изображения(*.bmp;*.jpeg;*.jpg)|*.bmp;*.jpeg;*.jpg";
            openFileDialog.ShowDialog();
            sourceImage = new Bitmap(openFileDialog.FileName);            
            pictureBox.Visible = true;
            pictureBox.Size = sourceImage.Size;
            this.Width = pictureBox.Width + 40;
            this.Height = pictureBox.Height + 77;
            this.CenterToScreen();
            pictureBox.Image = sourceImage;
            imageMenuItem.Visible = true;
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveAsFileMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Изображение BMP|*.bmp|Изображение JPEG|*.jpeg|Изображение JPG|*.jpg";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog.OpenFile();
                switch (saveFileDialog.FilterIndex)
                {
                    case 1:
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                    case 2:
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 3:
                        pictureBox.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                }
                fs.Close();
            }
        }

        private void filterImageMenuItem_Click(object sender, EventArgs e)
        {
            var resultBitmap = ImageProcess.FilterImage(sourceImage);
            pictureBox.Image = resultBitmap;
        }
    }
}
