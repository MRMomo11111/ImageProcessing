using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using openCV;
using System.IO;

namespace ImageProcessing
{
    
    public partial class FormHistogram : Form
    {
        Image sourseImage;
        public FormHistogram()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "JPEG|*JPG|Bitmap|*.bmp|All|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    sourseImage = Image.FromFile(openFileDialog1.FileName);
                    picBoxSource.Image = sourseImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnGetHistogram_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap)sourseImage;
            int width = sourseImage.Width;
            int hieght = sourseImage.Height;


            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;

                }
            }


            for (int i = 0; i < 256; i++)
            {
                histoChart.Series["Red"].Points.AddY(ni_Red[i]);
                histoChart.Series["Green"].Points.AddY(ni_Green[i]);
                histoChart.Series["Blue"].Points.AddY(ni_Blue[i]);
            }
        }

        private void btnEqualizeImage_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap)sourseImage;
            Bitmap newImage = bmpImg;
            int width = sourseImage.Width;
            int hieght = sourseImage.Height;


            //******************* Calculate N(i) **************//

            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];





            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;
                }
            }

            //******************* Calculate P(Ni) **************//
            decimal[] prob_ni_Red = new decimal[256];
            decimal[] prob_ni_Green = new decimal[256];
            decimal[] prob_ni_Blue = new decimal[256];

            for (int i = 0; i < 256; i++)
            {
                prob_ni_Red[i] = (decimal)ni_Red[i] / (decimal)(width * hieght);
                prob_ni_Green[i] = (decimal)ni_Green[i] / (decimal)(width * hieght);
                prob_ni_Blue[i] = (decimal)ni_Blue[i] / (decimal)(width * hieght);
            }

            //******************* Calculate CDF **************//

            decimal[] cdf_Red = new decimal[256];
            decimal[] cdf_Green = new decimal[256];
            decimal[] cdf_Blue = new decimal[256];

            cdf_Red[0] = prob_ni_Red[0];
            cdf_Green[0] = prob_ni_Green[0];
            cdf_Blue[0] = prob_ni_Blue[0];

            for (int i = 1; i < 256; i++)
            {
                cdf_Red[i] = prob_ni_Red[i] + cdf_Red[i - 1];
                cdf_Green[i] = prob_ni_Green[i - 1] + cdf_Green[i - 1];
                cdf_Blue[i] = prob_ni_Blue[i - 1] + cdf_Blue[i - 1];
            }


            //******************* Calculate CDF(L-1) **************//


            int red, green, blue;
            int constant = 255;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    red = (int)(cdf_Red[pixelColor.R] * constant);
                    green = (int)(cdf_Red[pixelColor.G] * constant);
                    blue = (int)(cdf_Red[pixelColor.B] * constant);

                    Color newColor = Color.FromArgb(red, green, blue);
                    newImage.SetPixel(i, j, newColor);

                }
            }

            picBoxEqualizedImage.Image = (Image)newImage;

            /*   MessageBox.Show("MN= "+width*hieght+"\n"
                   +"N(i)= "+ ni_Red[0]+"\n"
                   +"P(Ni)= "+prob_ni_Red[0]+"\n"
                   +"CDF= "+cdf_Red[255]);*/

        }

        private void btnGetEqualizedHistogram_Click(object sender, EventArgs e)
        {
            Bitmap bmpImg = (Bitmap)picBoxEqualizedImage.Image;
            int width = sourseImage.Width;
            int hieght = sourseImage.Height;


            int[] ni_Red = new int[256];
            int[] ni_Green = new int[256];
            int[] ni_Blue = new int[256];

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < hieght; j++)
                {
                    Color pixelColor = bmpImg.GetPixel(i, j);

                    ni_Red[pixelColor.R]++;
                    ni_Green[pixelColor.G]++;
                    ni_Blue[pixelColor.B]++;

                }
            }


            for (int i = 0; i < 256; i++)
            {
                chartEqualizedHisto.Series["Red"].Points.AddY(ni_Red[i]);
                chartEqualizedHisto.Series["Green"].Points.AddY(ni_Green[i]);
                chartEqualizedHisto.Series["Blue"].Points.AddY(ni_Blue[i]);
            }
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void chartEqualizedHisto_Click(object sender, EventArgs e)
        {

        }
    }
}
