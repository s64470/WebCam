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
            textBoxCamera = new TextBox();
            cbBoxCamera = new ComboBox();
            buttonExit = new Button();
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
            pictureBoxWebcamSurface.Location = new Point(12, 12);
            pictureBoxWebcamSurface.Name = "pictureBoxWebcamSurface";
            pictureBoxWebcamSurface.Size = new Size(776, 350);
            pictureBoxWebcamSurface.TabIndex = 2;
            pictureBoxWebcamSurface.TabStop = false;
            // 
            // textBoxCamera
            // 
            textBoxCamera.BorderStyle = BorderStyle.None;
            textBoxCamera.Location = new Point(12, 383);
            textBoxCamera.Name = "textBoxCamera";
            textBoxCamera.ReadOnly = true;
            textBoxCamera.Size = new Size(70, 20);
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
        private TextBox textBoxCamera;
        private ComboBox cbBoxCamera;
        private Button buttonExit;
    }
}