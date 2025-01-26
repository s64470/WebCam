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

        private FilterInfoCollection filterInfoCollection;
        private VideoCaptureDevice videoCaptureDevice;

        // Event handler to update picture frames
        // Start capturing webcam stream
        private void ButtonStartWebcam_Click(object sender, EventArgs e)
        {
            if (buttonWebcam.Text == "Start Webcam Stream")
            {
                // Start capturing stream
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbBoxCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;
                videoCaptureDevice.Start();

                buttonWebcam.Text = "Stop Webcam Stream";           // Change button value
            }
            else
            {
                // Stop capturing stream
                videoCaptureDevice.SignalToStop();
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame);

                buttonWebcam.Text = "Start Webcam Stream";          // Change button value
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