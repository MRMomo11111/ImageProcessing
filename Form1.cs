using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        Image sourceImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceImage = Image.FromFile(openFileDialog1.FileName);
                picBoxSource.Image = sourceImage;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            if (sourceImage == null)
                return;

            Bitmap bmpImg = new Bitmap(sourceImage);
            int width = bmpImg.Width;
            int height = bmpImg.Height;
            Bitmap newImage = new Bitmap(width, height);

            if (radbtnGaussianBlur.Checked)
            {
                ApplyGaussianBlur(bmpImg, newImage);
            }
            else if (radbtnSobelEdge.Checked)
            {
                ApplySobelEdgeDetection(bmpImg, newImage);
            }
            else if (radbtnBrightness.Checked)
            {
                AdjustBrightness(bmpImg, newImage, 50); // زود الإضاءة بمقدار 50
            }
            else if (radbtnNegative.Checked)
            {
                ApplyNegativeFilter(bmpImg, newImage);
            }

            picBoxFiltered.Image = newImage;
        }

        private void ApplyGaussianBlur(Bitmap source, Bitmap target)
        {
            // كيرنل جاوسيان بلور 5×5 معياري
            int[,] kernel = {
        { 1, 4, 6, 4, 1 },
        { 4, 16, 24, 16, 4 },
        { 6, 24, 36, 24, 6 },
        { 4, 16, 24, 16, 4 },
        { 1, 4, 6, 4, 1 }
    };
            int kernelSum = 256; // مجموع الكيرنل للتطبيع

            int width = source.Width;
            int height = source.Height;

            // تطبيق الفلتر باستخدام GetPixel/SetPixel (أبسط للفهم)
            // تخطي حافة 2 بكسل من كل جانب لأن كيرنل 5×5 يحتاج 2 بكسل من الحافة
            for (int y = 2; y < height - 2; y++)
            {
                for (int x = 2; x < width - 2; x++)
                {
                    int redSum = 0, greenSum = 0, blueSum = 0;

                    // تطبيق الكيرنل
                    for (int j = -2; j <= 2; j++)
                    {
                        for (int i = -2; i <= 2; i++)
                        {
                            Color pixel = source.GetPixel(x + i, y + j);
                            int weight = kernel[j + 2, i + 2];

                            redSum += pixel.R * weight;
                            greenSum += pixel.G * weight;
                            blueSum += pixel.B * weight;
                        }
                    }

                    // تطبيع وتعيين قيمة البكسل الجديدة
                    int r = Math.Min(255, Math.Max(0, redSum / kernelSum));
                    int g = Math.Min(255, Math.Max(0, greenSum / kernelSum));
                    int b = Math.Min(255, Math.Max(0, blueSum / kernelSum));

                    target.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            // نسخ البكسلات عند الحافة من الصورة الأصلية
            // - أعلى
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    target.SetPixel(x, y, source.GetPixel(x, y));
                }
            }
            // - أسفل
            for (int y = height - 2; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    target.SetPixel(x, y, source.GetPixel(x, y));
                }
            }
            // - يسار ويمين (باستثناء الزوايا التي تم تغطيتها بالفعل)
            for (int y = 2; y < height - 2; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    target.SetPixel(x, y, source.GetPixel(x, y));
                }
                for (int x = width - 2; x < width; x++)
                {
                    target.SetPixel(x, y, source.GetPixel(x, y));
                }
            }
        }


        private void ApplySobelEdgeDetection(Bitmap source, Bitmap target)
        {
            int[,] gx = {
                { -1, 0, 1 },
                { -2, 0, 2 },
                { -1, 0, 1 }
            };

            int[,] gy = {
                { -1, -2, -1 },
                { 0,  0,  0 },
                { 1,  2,  1 }
            };

            int width = source.Width;
            int height = source.Height;

            for (int i = 1; i < width - 1; i++)
            {
                for (int j = 1; j < height - 1; j++)
                {
                    double pixelX = 0;
                    double pixelY = 0;

                    for (int x = -1; x <= 1; x++)
                    {
                        for (int y = -1; y <= 1; y++)
                        {
                            Color pixel = source.GetPixel(i + x, j + y);
                            int gray = (pixel.R + pixel.G + pixel.B) / 3;

                            pixelX += gx[x + 1, y + 1] * gray;
                            pixelY += gy[x + 1, y + 1] * gray;
                        }
                    }

                    int val = (int)Math.Sqrt((pixelX * pixelX) + (pixelY * pixelY));
                    val = Math.Min(255, Math.Max(0, val));

                    target.SetPixel(i, j, Color.FromArgb(val, val, val));
                }
            }
        }

        private void AdjustBrightness(Bitmap source, Bitmap target, int value)
        {
            int width = source.Width;
            int height = source.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = source.GetPixel(i, j);

                    int r = Math.Min(255, Math.Max(0, pixel.R + value));
                    int g = Math.Min(255, Math.Max(0, pixel.G + value));
                    int b = Math.Min(255, Math.Max(0, pixel.B + value));

                    target.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
        }

        private void ApplyNegativeFilter(Bitmap source, Bitmap target)
        {
            int width = source.Width;
            int height = source.Height;

            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Color pixel = source.GetPixel(i, j);

                    int r = 255 - pixel.R;
                    int g = 255 - pixel.G;
                    int b = 255 - pixel.B;

                    target.SetPixel(i, j, Color.FromArgb(r, g, b));
                }
            }
        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            // Add functionality if required for this button.
        }

        private void btnFormHistogram_Click(object sender, EventArgs e)
        {
            FormHistogram formHistogram = new FormHistogram();
            formHistogram.Show();
        }

        private void btnFormRGB_Click(object sender, EventArgs e)
        {
            FormRGB formRGB = new FormRGB();
            formRGB.Show();
        }

        private void radbtnNegative_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radbtnBrightness_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void radbtnSobelEdge_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
