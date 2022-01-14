namespace app
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.InputBox = new System.Windows.Forms.TextBox();
            this.GenButton = new System.Windows.Forms.Button();
            this.ExpireLabel = new System.Windows.Forms.Label();
            this.BackImage = new System.Windows.Forms.PictureBox();
            this.TimerConst = new System.Windows.Forms.Label();
            this.TimeLabels = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.CurrentTime = new System.Windows.Forms.Label();
            this.GifBox = new System.Windows.Forms.PictureBox();
            this.QR2 = new System.Windows.Forms.PictureBox();
            this.TextField = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BackImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR2)).BeginInit();
            this.SuspendLayout();
            // 
            // InputBox
            // 
            this.InputBox.Location = new System.Drawing.Point(93, 189);
            this.InputBox.Name = "InputBox";
            this.InputBox.Size = new System.Drawing.Size(100, 20);
            this.InputBox.TabIndex = 1;
            // 
            // GenButton
            // 
            this.GenButton.Location = new System.Drawing.Point(222, 187);
            this.GenButton.Name = "GenButton";
            this.GenButton.Size = new System.Drawing.Size(75, 23);
            this.GenButton.TabIndex = 2;
            this.GenButton.Text = "Generate";
            this.GenButton.UseVisualStyleBackColor = true;
            this.GenButton.Click += new System.EventHandler(this.GenButton_Click);
            // 
            // ExpireLabel
            // 
            this.ExpireLabel.AutoSize = true;
            this.ExpireLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpireLabel.Location = new System.Drawing.Point(8, 793);
            this.ExpireLabel.Name = "ExpireLabel";
            this.ExpireLabel.Size = new System.Drawing.Size(68, 19);
            this.ExpireLabel.TabIndex = 5;
            this.ExpireLabel.Text = "Day/Date";
            this.ExpireLabel.Visible = false;
            // 
            // BackImage
            // 
            this.BackImage.Image = ((System.Drawing.Image)(resources.GetObject("BackImage.Image")));
            this.BackImage.Location = new System.Drawing.Point(-7, -7);
            this.BackImage.Name = "BackImage";
            this.BackImage.Size = new System.Drawing.Size(412, 892);
            this.BackImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BackImage.TabIndex = 6;
            this.BackImage.TabStop = false;
            this.BackImage.Visible = false;
            // 
            // TimerConst
            // 
            this.TimerConst.AutoSize = true;
            this.TimerConst.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.TimerConst.Location = new System.Drawing.Point(60, 609);
            this.TimerConst.Name = "TimerConst";
            this.TimerConst.Size = new System.Drawing.Size(265, 31);
            this.TimerConst.TabIndex = 8;
            this.TimerConst.Text = "00  :  00  :  29  :  59";
            this.TimerConst.Visible = false;
            // 
            // TimeLabels
            // 
            this.TimeLabels.AutoSize = true;
            this.TimeLabels.Location = new System.Drawing.Point(68, 643);
            this.TimeLabels.Name = "TimeLabels";
            this.TimeLabels.Size = new System.Drawing.Size(248, 13);
            this.TimeLabels.TabIndex = 9;
            this.TimeLabels.Text = "days                 hours                mins                 secs";
            this.TimeLabels.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // CurrentTime
            // 
            this.CurrentTime.AutoSize = true;
            this.CurrentTime.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentTime.Location = new System.Drawing.Point(135, 528);
            this.CurrentTime.Name = "CurrentTime";
            this.CurrentTime.Size = new System.Drawing.Size(129, 38);
            this.CurrentTime.TabIndex = 10;
            this.CurrentTime.Text = "00:00:00";
            this.CurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CurrentTime.Visible = false;
            // 
            // GifBox
            // 
            this.GifBox.BackColor = System.Drawing.Color.Transparent;
            this.GifBox.Image = ((System.Drawing.Image)(resources.GetObject("GifBox.Image")));
            this.GifBox.Location = new System.Drawing.Point(3, 319);
            this.GifBox.Name = "GifBox";
            this.GifBox.Size = new System.Drawing.Size(391, 265);
            this.GifBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifBox.TabIndex = 12;
            this.GifBox.TabStop = false;
            this.GifBox.Visible = false;
            // 
            // QR2
            // 
            this.QR2.Image = ((System.Drawing.Image)(resources.GetObject("QR2.Image")));
            this.QR2.Location = new System.Drawing.Point(75, 142);
            this.QR2.Name = "QR2";
            this.QR2.Size = new System.Drawing.Size(245, 245);
            this.QR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.QR2.TabIndex = 13;
            this.QR2.TabStop = false;
            this.QR2.Visible = false;
            // 
            // TextField
            // 
            this.TextField.AutoSize = true;
            this.TextField.BackColor = System.Drawing.Color.Transparent;
            this.TextField.Font = new System.Drawing.Font("Comic Sans MS", 45F, System.Drawing.FontStyle.Bold);
            this.TextField.ForeColor = System.Drawing.Color.Black;
            this.TextField.Location = new System.Drawing.Point(114, 408);
            this.TextField.Name = "TextField";
            this.TextField.Size = new System.Drawing.Size(177, 84);
            this.TextField.TabIndex = 14;
            this.TextField.Text = "blast";
            this.TextField.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextField.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 853);
            this.Controls.Add(this.TextField);
            this.Controls.Add(this.QR2);
            this.Controls.Add(this.CurrentTime);
            this.Controls.Add(this.TimeLabels);
            this.Controls.Add(this.TimerConst);
            this.Controls.Add(this.ExpireLabel);
            this.Controls.Add(this.GenButton);
            this.Controls.Add(this.InputBox);
            this.Controls.Add(this.GifBox);
            this.Controls.Add(this.BackImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.BackImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QR2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputBox;
        private System.Windows.Forms.Button GenButton;
        private System.Windows.Forms.Label ExpireLabel;
        private System.Windows.Forms.PictureBox BackImage;
        private System.Windows.Forms.Label TimerConst;
        private System.Windows.Forms.Label TimeLabels;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label CurrentTime;
        private System.Windows.Forms.PictureBox GifBox;
        private System.Windows.Forms.PictureBox QR2;
        private System.Windows.Forms.Label TextField;
    }
}

