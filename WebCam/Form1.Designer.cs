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
            buttonWebcam = new Button();
            pictureBoxWebcamSurface = new PictureBox();
            tBCamera = new TextBox();
            cbBoxCamera = new ComboBox();
            buttonExit = new Button();
            buttonCaptureStream = new Button();
            cBFileContainer = new ComboBox();
            tBFiles = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebcamSurface).BeginInit();
            SuspendLayout();
            // 
            // buttonWebcam
            // 
            buttonWebcam.Location = new Point(12, 409);
            buttonWebcam.Name = "buttonWebcam";
            buttonWebcam.Size = new Size(170, 29);
            buttonWebcam.TabIndex = 0;
            buttonWebcam.Text = "Start webcam stream";
            buttonWebcam.UseVisualStyleBackColor = true;
            buttonWebcam.Click += ButtonStartWebcam_Click;
            // 
            // pictureBoxWebcamSurface
            // 
            pictureBoxWebcamSurface.BackColor = SystemColors.ActiveCaptionText;
            pictureBoxWebcamSurface.Location = new Point(12, 12);
            pictureBoxWebcamSurface.Name = "pictureBoxWebcamSurface";
            pictureBoxWebcamSurface.Size = new Size(483, 350);
            pictureBoxWebcamSurface.TabIndex = 2;
            pictureBoxWebcamSurface.TabStop = false;
            // 
            // tBCamera
            // 
            tBCamera.BorderStyle = BorderStyle.None;
            tBCamera.Location = new Point(12, 383);
            tBCamera.Name = "tBCamera";
            tBCamera.ReadOnly = true;
            tBCamera.Size = new Size(70, 20);
            tBCamera.TabIndex = 3;
            tBCamera.Text = "Camera:";
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
            // buttonCaptureStream
            // 
            buttonCaptureStream.Location = new Point(188, 409);
            buttonCaptureStream.Name = "buttonCaptureStream";
            buttonCaptureStream.Size = new Size(94, 29);
            buttonCaptureStream.TabIndex = 6;
            buttonCaptureStream.Text = "Capture";
            buttonCaptureStream.UseVisualStyleBackColor = true;
            buttonCaptureStream.Click += ButtonCaptureStream_Click;
            // 
            // cBFileContainer
            // 
            cBFileContainer.FormattingEnabled = true;
            cBFileContainer.Location = new Point(517, 38);
            cBFileContainer.Name = "cBFileContainer";
            cBFileContainer.Size = new Size(271, 28);
            cBFileContainer.TabIndex = 7;
            // 
            // tBFiles
            // 
            tBFiles.BackColor = SystemColors.Control;
            tBFiles.BorderStyle = BorderStyle.None;
            tBFiles.Location = new Point(517, 12);
            tBFiles.Name = "tBFiles";
            tBFiles.Size = new Size(125, 20);
            tBFiles.TabIndex = 9;
            tBFiles.Text = "Saved Pictures:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tBFiles);
            Controls.Add(cBFileContainer);
            Controls.Add(buttonCaptureStream);
            Controls.Add(buttonExit);
            Controls.Add(cbBoxCamera);
            Controls.Add(tBCamera);
            Controls.Add(pictureBoxWebcamSurface);
            Controls.Add(buttonWebcam);
            Name = "Form1";
            Text = "Webcam";
            Load += Form1_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebcamSurface).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonWebcam;
        private PictureBox pictureBoxWebcamSurface;
        private TextBox tBCamera;
        private ComboBox cbBoxCamera;
        private Button buttonExit;
        private Button buttonCaptureStream;
        private ComboBox cBFileContainer;
        private TextBox tBFiles;
    }
}