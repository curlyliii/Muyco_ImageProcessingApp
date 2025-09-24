namespace Muyco_ImageProcessingApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxOriginal = new System.Windows.Forms.PictureBox();
            this.pictureBoxProcessed = new System.Windows.Forms.PictureBox();
            this.pictureBoxSubtracted = new System.Windows.Forms.PictureBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnGrayscale = new System.Windows.Forms.Button();
            this.btnInvert = new System.Windows.Forms.Button();
            this.btnSepia = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoadA = new System.Windows.Forms.Button();
            this.btnLoadB = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBoxImageA = new System.Windows.Forms.PictureBox();
            this.pictureBoxImageB = new System.Windows.Forms.PictureBox();
            this.pictureBoxWebcam = new System.Windows.Forms.PictureBox();
            this.btnStartWebcam = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtracted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxOriginal
            // 
            this.pictureBoxOriginal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxOriginal.Location = new System.Drawing.Point(398, 56);
            this.pictureBoxOriginal.Name = "pictureBoxOriginal";
            this.pictureBoxOriginal.Size = new System.Drawing.Size(338, 256);
            this.pictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxOriginal.TabIndex = 0;
            this.pictureBoxOriginal.TabStop = false;
            // 
            // pictureBoxProcessed
            // 
            this.pictureBoxProcessed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxProcessed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProcessed.Location = new System.Drawing.Point(778, 56);
            this.pictureBoxProcessed.Name = "pictureBoxProcessed";
            this.pictureBoxProcessed.Size = new System.Drawing.Size(341, 256);
            this.pictureBoxProcessed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProcessed.TabIndex = 1;
            this.pictureBoxProcessed.TabStop = false;
            // 
            // pictureBoxSubtracted
            // 
            this.pictureBoxSubtracted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxSubtracted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSubtracted.Location = new System.Drawing.Point(778, 451);
            this.pictureBoxSubtracted.Name = "pictureBoxSubtracted";
            this.pictureBoxSubtracted.Size = new System.Drawing.Size(341, 256);
            this.pictureBoxSubtracted.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSubtracted.TabIndex = 2;
            this.pictureBoxSubtracted.TabStop = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(628, 18);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(108, 32);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load Image";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1151, 78);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(108, 32);
            this.btnCopy.TabIndex = 4;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnGrayscale
            // 
            this.btnGrayscale.Location = new System.Drawing.Point(1151, 204);
            this.btnGrayscale.Name = "btnGrayscale";
            this.btnGrayscale.Size = new System.Drawing.Size(108, 32);
            this.btnGrayscale.TabIndex = 5;
            this.btnGrayscale.Text = "Grayscale";
            this.btnGrayscale.UseVisualStyleBackColor = true;
            this.btnGrayscale.Click += new System.EventHandler(this.btnGrayscale_Click);
            // 
            // btnInvert
            // 
            this.btnInvert.Location = new System.Drawing.Point(1151, 139);
            this.btnInvert.Name = "btnInvert";
            this.btnInvert.Size = new System.Drawing.Size(108, 32);
            this.btnInvert.TabIndex = 6;
            this.btnInvert.Text = "Invert Colors";
            this.btnInvert.UseVisualStyleBackColor = true;
            this.btnInvert.Click += new System.EventHandler(this.btnInvert_Click);
            // 
            // btnSepia
            // 
            this.btnSepia.Location = new System.Drawing.Point(1151, 260);
            this.btnSepia.Name = "btnSepia";
            this.btnSepia.Size = new System.Drawing.Size(108, 32);
            this.btnSepia.TabIndex = 7;
            this.btnSepia.Text = "Sepia";
            this.btnSepia.UseVisualStyleBackColor = true;
            this.btnSepia.Click += new System.EventHandler(this.btnSepia_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1011, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(108, 32);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoadA
            // 
            this.btnLoadA.Location = new System.Drawing.Point(245, 413);
            this.btnLoadA.Name = "btnLoadA";
            this.btnLoadA.Size = new System.Drawing.Size(108, 32);
            this.btnLoadA.TabIndex = 9;
            this.btnLoadA.Text = "Load Image A";
            this.btnLoadA.UseVisualStyleBackColor = true;
            this.btnLoadA.Click += new System.EventHandler(this.btnLoadA_Click);
            // 
            // btnLoadB
            // 
            this.btnLoadB.Location = new System.Drawing.Point(628, 413);
            this.btnLoadB.Name = "btnLoadB";
            this.btnLoadB.Size = new System.Drawing.Size(108, 32);
            this.btnLoadB.TabIndex = 10;
            this.btnLoadB.Text = "Load Image B";
            this.btnLoadB.UseVisualStyleBackColor = true;
            this.btnLoadB.Click += new System.EventHandler(this.btnLoadB_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(959, 413);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(160, 32);
            this.btnSubtract.TabIndex = 11;
            this.btnSubtract.Text = "Subtract Images";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(395, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Original Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(775, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Processed Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(775, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Subtracted Image";
            // 
            // pictureBoxImageA
            // 
            this.pictureBoxImageA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxImageA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageA.Location = new System.Drawing.Point(15, 451);
            this.pictureBoxImageA.Name = "pictureBoxImageA";
            this.pictureBoxImageA.Size = new System.Drawing.Size(338, 256);
            this.pictureBoxImageA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageA.TabIndex = 15;
            this.pictureBoxImageA.TabStop = false;
            // 
            // pictureBoxImageB
            // 
            this.pictureBoxImageB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxImageB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImageB.Location = new System.Drawing.Point(395, 451);
            this.pictureBoxImageB.Name = "pictureBoxImageB";
            this.pictureBoxImageB.Size = new System.Drawing.Size(341, 256);
            this.pictureBoxImageB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImageB.TabIndex = 16;
            this.pictureBoxImageB.TabStop = false;
            // 
            // pictureBoxWebcam
            // 
            this.pictureBoxWebcam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxWebcam.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxWebcam.Location = new System.Drawing.Point(12, 56);
            this.pictureBoxWebcam.Name = "pictureBoxWebcam";
            this.pictureBoxWebcam.Size = new System.Drawing.Size(338, 256);
            this.pictureBoxWebcam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWebcam.TabIndex = 17;
            this.pictureBoxWebcam.TabStop = false;
            // 
            // btnStartWebcam
            // 
            this.btnStartWebcam.Location = new System.Drawing.Point(192, 18);
            this.btnStartWebcam.Name = "btnStartWebcam";
            this.btnStartWebcam.Size = new System.Drawing.Size(158, 32);
            this.btnStartWebcam.TabIndex = 18;
            this.btnStartWebcam.Text = "Start Webcam";
            this.btnStartWebcam.UseVisualStyleBackColor = true;
            this.btnStartWebcam.Click += new System.EventHandler(this.btnStartWebcam_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Webcam";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "For Image Subtraction";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Background Image";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 421);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Image with Greenscreen";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 728);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnStartWebcam);
            this.Controls.Add(this.pictureBoxWebcam);
            this.Controls.Add(this.pictureBoxImageB);
            this.Controls.Add(this.pictureBoxImageA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnLoadB);
            this.Controls.Add(this.btnLoadA);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSepia);
            this.Controls.Add(this.btnInvert);
            this.Controls.Add(this.btnGrayscale);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.pictureBoxSubtracted);
            this.Controls.Add(this.pictureBoxProcessed);
            this.Controls.Add(this.pictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProcessed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSubtracted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImageB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWebcam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxOriginal;
        private System.Windows.Forms.PictureBox pictureBoxProcessed;
        private System.Windows.Forms.PictureBox pictureBoxSubtracted;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnGrayscale;
        private System.Windows.Forms.Button btnInvert;
        private System.Windows.Forms.Button btnSepia;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoadA;
        private System.Windows.Forms.Button btnLoadB;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBoxImageA;
        private System.Windows.Forms.PictureBox pictureBoxImageB;
        private System.Windows.Forms.PictureBox pictureBoxWebcam;
        private System.Windows.Forms.Button btnStartWebcam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

