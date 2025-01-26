//AForge.Video dll
using AForge.Video;
using AForge.Video.DirectShow;

//System dll
using System.Drawing.Imaging;

namespace WebCam
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection filterInfoCollection;          // List of webcam
        private VideoCaptureDevice videoCaptureDevice;
        private readonly String fileLocation = "ImageStorage\\stream.png";

        public Form1()
        {
            InitializeComponent();
        }

        // Event handler to update picture frames
        // Start capturing webcam stream
        private void ButtonStartWebcam_Click(object sender, EventArgs e)
        {
            if (buttonWebcam.Text == "Start webcam stream")
            {
                // Start capturing stream
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbBoxCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();

                buttonWebcam.Text = "Stop webcam stream";           // Change button value
            }
            else
            {
                // Stop capturing stream
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame);

                buttonWebcam.Text = "Start webcam stream";          // Change button value
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxWebcamSurface.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Identify the webcam from a computer and add it to the combobox
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbBoxCamera.Items.Add(filterInfo.Name);
                cbBoxCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
        }

        // Exit Windows Forms app
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // Stop capturing stream
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame);

                // Windows Forms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        // Capture webcam stream
        private void ButtonCaptureStream_Click(object sender, EventArgs e)
        {
            if (pictureBoxWebcamSurface.Image != null)
            {
                //Save First
                Bitmap varBmp = new(pictureBoxWebcamSurface.Image);
                _ = new Bitmap(varBmp);
                varBmp.Save(fileLocation, ImageFormat.Png);

                //Now Dispose to free the memory
                varBmp.Dispose();
            }
            else
            { MessageBox.Show("No stream"); }
        }
    }
}