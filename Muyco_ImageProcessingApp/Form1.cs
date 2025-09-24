using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Muyco_ImageProcessingApp
{
    public partial class Form1 : Form
    {
        Bitmap originalImage, imageA, imageB, resultImage; 
        FilterInfoCollection videoDevices;
        VideoCaptureDevice videoSource;
        string currentFilter = "None";
        bool useLiveWebcam = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(open.FileName);
                pictureBoxOriginal.Image = originalImage;
                useLiveWebcam = false;
            }
        }

        private void btnGrayscale_Click(object sender, EventArgs e)
        {
            currentFilter = "Grayscale";
            if (!useLiveWebcam) ApplyFilterToOriginal();
        }

        private void btnInvert_Click(object sender, EventArgs e)
        {
            currentFilter = "Invert";
            if (!useLiveWebcam) ApplyFilterToOriginal();
        }

        private void btnSepia_Click(object sender, EventArgs e)
        {
            currentFilter = "Sepia";
            if (!useLiveWebcam) ApplyFilterToOriginal();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            currentFilter = "Copy";
            if (!useLiveWebcam) ApplyFilterToOriginal();
        }

        private void ApplyFilterToOriginal()
        {
            if (originalImage == null)
            {
                MessageBox.Show("Please load an image first.");
                return;
            }

            Bitmap processed = ApplyFilter(originalImage, currentFilter);
            pictureBoxProcessed.Image = processed;
        }

        private Bitmap ApplyFilter(Bitmap source, string filter)
        {
            Bitmap result = new Bitmap(source.Width, source.Height);

            for (int x = 0; x < source.Width; x++)
            {
                for (int y = 0; y < source.Height; y++)
                {
                    Color c = source.GetPixel(x, y);
                    Color newColor = c;

                    switch (filter)
                    {
                        case "Grayscale":
                            int avg = (c.R + c.G + c.B) / 3;
                            newColor = Color.FromArgb(avg, avg, avg);
                            break;

                        case "Invert":
                            newColor = Color.FromArgb(255 - c.R, 255 - c.G, 255 - c.B);
                            break;

                        case "Sepia":
                            int r = (int)(0.393 * c.R + 0.769 * c.G + 0.189 * c.B);
                            int g = (int)(0.349 * c.R + 0.686 * c.G + 0.168 * c.B);
                            int b = (int)(0.272 * c.R + 0.534 * c.G + 0.131 * c.B);
                            newColor = Color.FromArgb(
                                Math.Min(255, r),
                                Math.Min(255, g),
                                Math.Min(255, b));
                            break;

                        case "Copy":
                            newColor = c;
                            break;
                    }

                    result.SetPixel(x, y, newColor);
                }
            }

            return result;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pictureBoxProcessed.Image == null)
            {
                MessageBox.Show("No image to save.");
                return;
            }

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "PNG Image|*.png";
            if (save.ShowDialog() == DialogResult.OK)
            {
                Bitmap bmp = new Bitmap(pictureBoxProcessed.Image);
                bmp.Save(save.FileName);
            }
        }

        private void btnLoadA_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog3 = new OpenFileDialog();
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                imageA = new Bitmap(openFileDialog3.FileName);
                pictureBoxImageA.Image = imageA;  
            }
        }

        private void btnLoadB_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog2 = new OpenFileDialog();
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                imageB = new Bitmap(openFileDialog2.FileName);
                pictureBoxImageB.Image = imageB;
            }
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (imageA == null || imageB == null)
            {
                MessageBox.Show("Please load both Image A (background) and Image B (green screen foreground).");
                return;
            }

            resultImage = new Bitmap(imageA.Width, imageA.Height);
            Color greenKey = Color.FromArgb(0, 255, 0); 
            double threshold = 100.0; 
            for (int x = 0; x < imageB.Width; x++)
            {
                for (int y = 0; y < imageB.Height; y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backpixel = imageA.GetPixel(x, y);

                    int dr = pixel.R - greenKey.R;
                    int dg = pixel.G - greenKey.G;
                    int db = pixel.B - greenKey.B;

                    double distance = Math.Sqrt(dr * dr + dg * dg + db * db);

                    resultImage.SetPixel(x, y, distance < threshold ? backpixel : pixel);
                }
            }

            pictureBoxSubtracted.Image = resultImage;
        }

        private void btnStartWebcam_Click(object sender, EventArgs e)
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No webcam found.");
                return;
            }

            videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
            videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
            videoSource.Start();
            useLiveWebcam = true;
        }

        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap frame = (Bitmap)eventArgs.Frame.Clone();
            Bitmap processed = ApplyFilter(frame, currentFilter);
            pictureBoxWebcam.Image = processed;
        }
    }
}
