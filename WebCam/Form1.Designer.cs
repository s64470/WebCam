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
            button1 = new Button();
            button2 = new Button();
            pictureBoxWebcamSurface = new PictureBox();
            textBoxCamera = new TextBox();
            cbBoxCamera = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebcamSurface).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 409);
            button1.Name = "button1";
            button1.Size = new Size(110, 29);
            button1.TabIndex = 0;
            button1.Text = "Start Webcam";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(678, 409);
            button2.Name = "button2";
            button2.Size = new Size(110, 29);
            button2.TabIndex = 1;
            button2.Text = "Stop Webcam";
            button2.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbBoxCamera);
            Controls.Add(textBoxCamera);
            Controls.Add(pictureBoxWebcamSurface);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Webcam";
            ((System.ComponentModel.ISupportInitialize)pictureBoxWebcamSurface).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBoxWebcamSurface;
        private TextBox textBoxCamera;
        private ComboBox cbBoxCamera;
    }
}
