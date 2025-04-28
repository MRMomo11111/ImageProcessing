using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using openCV;
using static System.Net.Mime.MediaTypeNames;

namespace ImageProcessing
{
  
    public partial class FormRGB : Form
    {
        IplImage sourceImage;
        Bitmap bmp;
        public FormRGB()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = " ";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*-11";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourceImage = cvlib.CvLoadImage(openFileDialog1.FileName, cvlib.CV_LOAD_IMAGE_COLOR);
                    CvSize size = new CvSize(picSourceImage.Width, picSourceImage.Height);
                    IplImage resized_image = cvlib.CvCreateImage(size, sourceImage.depth,sourceImage.nChannels);
                    cvlib.CvResize(ref sourceImage, ref resized_image, cvlib.CV_INTER_LINEAR);
                    picSourceImage.BackgroundImage = (Bitmap)resized_image;





                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnRed_Click(object sender, EventArgs e)
{
    Bitmap bmpImg = (Bitmap)sourceImage;
    int width = bmpImg.Width;
    int height = bmpImg.Height;
    Bitmap redImage = new Bitmap(width, height); // إنشاء صورة جديدة للقناة الحمراء

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Color pixelColor = bmpImg.GetPixel(i, j);
            int r = pixelColor.R;
            Color red = Color.FromArgb(r, 0, 0); // إبقاء اللون الأحمر فقط
            redImage.SetPixel(i, j, red);
        }
    }

    picBoxRed.Image = redImage; // عرض الصورة الحمراء
}

private void btnGreen_Click(object sender, EventArgs e)
{
    Bitmap bmpImg = (Bitmap)sourceImage;
    int width = bmpImg.Width;
    int height = bmpImg.Height;
    Bitmap greenImage = new Bitmap(width, height); // إنشاء صورة جديدة للقناة الخضراء

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Color pixelColor = bmpImg.GetPixel(i, j);
            int g = pixelColor.G;
            Color green = Color.FromArgb(0, g, 0); // إبقاء اللون الأخضر فقط
            greenImage.SetPixel(i, j, green);
        }
    }

    picBoxGreen.Image = greenImage; // عرض الصورة الخضراء
}

private void btnBlue_Click(object sender, EventArgs e)
{
    Bitmap bmpImg = (Bitmap)sourceImage;
    int width = bmpImg.Width;
    int height = bmpImg.Height;
    Bitmap blueImage = new Bitmap(width, height); // إنشاء صورة جديدة للقناة الزرقاء

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Color pixelColor = bmpImg.GetPixel(i, j);
            int b = pixelColor.B;
            Color blue = Color.FromArgb(0, 0, b); // إبقاء اللون الأزرق فقط
            blueImage.SetPixel(i, j, blue);
        }
    }

    picBoxBlue.Image = blueImage; // عرض الصورة الزرقاء
}

private void convertToGreyToolStripMenuItem_Click(object sender, EventArgs e)
{
    Bitmap bmpImg = (Bitmap)sourceImage;
    int width = bmpImg.Width;
    int height = bmpImg.Height;
    Bitmap greyImage = new Bitmap(width, height); // إنشاء صورة جديدة باللون الرمادي

    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < height; j++)
        {
            Color pixelColor = bmpImg.GetPixel(i, j);
            int a = pixelColor.A;
            int r = pixelColor.R;
            int g = pixelColor.G;
            int b = pixelColor.B;
            int avg = (r + g + b) / 3; // حساب متوسط الألوان
            greyImage.SetPixel(i, j, Color.FromArgb(a, avg, avg, avg)); // تعيين اللون الرمادي
        }
    }

    pictureBox1.Image = greyImage; // عرض الصورة الرمادية
}



            private void picSourceImage_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
