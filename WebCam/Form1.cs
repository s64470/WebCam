using AForge.Video;
using AForge.Video.DirectShow;

namespace WebCam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        // Event handler to update picture frames
        // Start captureing webcam frames
        private void ButtonStartWebcam_Click(object sender, EventArgs e)
        {
            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbBoxCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
            videoCaptureDevice.Start();
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // throw new NotImplementedException();
            pictureBoxWebcamSurface.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            // Identify the Webcam from a computer and add it to the combobox
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                cbBoxCamera.Items.Add(filterInfo.Name);
                cbBoxCamera.SelectedIndex = 0;
                videoCaptureDevice = new VideoCaptureDevice();
            }
        }

        private void ButtonStopWebcam_Click(object sender, EventArgs e)
        {
        }

        // Exit Windows Forms app
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // Windows Forms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }
    }
}