namespace WebCam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonStartWebcam = new Button();
            buttonStopWebcam = new Button();
            pictureBoxWebcamSurface = new PictureBox();
            textBoxCamera = new TextBox();
            cbBoxCamera = new ComboBox();
            buttonExit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebcamSurface).BeginInit();
            SuspendLayout();
            // 
            // buttonStartWebcam
            // 
            buttonStartWebcam.Location = new Point(12, 409);
            buttonStartWebcam.Name = "buttonStartWebcam";
            buttonStartWebcam.Size = new Size(110, 29);
            buttonStartWebcam.TabIndex = 0;
            buttonStartWebcam.Text = "Start Webcam";
            buttonStartWebcam.UseVisualStyleBackColor = true;
            buttonStartWebcam.Click += ButtonStartWebcam_Click;
            // 
            // buttonStopWebcam
            // 
            buttonStopWebcam.Location = new Point(143, 409);
            buttonStopWebcam.Name = "buttonStopWebcam";
            buttonStopWebcam.Size = new Size(110, 29);
            buttonStopWebcam.TabIndex = 1;
            buttonStopWebcam.Text = "Stop Webcam";
            buttonStopWebcam.UseVisualStyleBackColor = true;
            buttonStopWebcam.Click += ButtonStopWebcam_Click;
            // 
            // pictureBoxWebcamSurface
            // 
            pictureBoxWebcamSurface.Location = new Point(12, 12);
            pictureBoxWebcamSurface.Name = "pictureBoxWebcamSurface";
            pictureBoxWebcamSurface.Size = new Size(776, 350);
            pictureBoxWebcamSurface.TabIndex = 2;
            pictureBoxWebcamSurface.TabStop = false;
            // 
            // textBoxCamera
            // 
            textBoxCamera.Location = new Point(12, 376);
            textBoxCamera.Name = "textBoxCamera";
            textBoxCamera.ReadOnly = true;
            textBoxCamera.Size = new Size(125, 27);
            textBoxCamera.TabIndex = 3;
            textBoxCamera.Text = "Camera:";
            // 
            // cbBoxCamera
            // 
            cbBoxCamera.FormattingEnabled = true;
            cbBoxCamera.Location = new Point(143, 375);
            cbBoxCamera.Name = "cbBoxCamera";
            cbBoxCamera.Size = new Size(250, 28);
            cbBoxCamera.TabIndex = 4;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(678, 409);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(110, 29);
            buttonExit.TabIndex = 5;
            buttonExit.Text = "Exit";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += ButtonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(cbBoxCamera);
            Controls.Add(textBoxCamera);
            Controls.Add(pictureBoxWebcamSurface);
            Controls.Add(buttonStopWebcam);
            Controls.Add(buttonStartWebcam);
            Name = "Form1";
            Text = "Webcam";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebcamSurface).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonStartWebcam;
        private Button buttonStopWebcam;
        private PictureBox pictureBoxWebcamSurface;
        private TextBox textBoxCamera;
        private ComboBox cbBoxCamera;
        private Button buttonExit;
    }
}
