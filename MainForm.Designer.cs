namespace YoutubeDownloaderWindowsForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.downloadvideobtn = new System.Windows.Forms.Button();
            this.downloadaudiobtn = new System.Windows.Forms.Button();
            this.urltext = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.radiobtn360p = new System.Windows.Forms.RadioButton();
            this.radiobtn720p = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtn1080p = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.helpbtn = new System.Windows.Forms.Button();
            this.aboutbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.videoinfobtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // downloadvideobtn
            // 
            this.downloadvideobtn.BackColor = System.Drawing.Color.SteelBlue;
            this.downloadvideobtn.Location = new System.Drawing.Point(606, 142);
            this.downloadvideobtn.Name = "downloadvideobtn";
            this.downloadvideobtn.Size = new System.Drawing.Size(120, 45);
            this.downloadvideobtn.TabIndex = 0;
            this.downloadvideobtn.Text = "Download Video";
            this.downloadvideobtn.UseVisualStyleBackColor = false;
            this.downloadvideobtn.Click += new System.EventHandler(this.downloadvideobtn_click);
            // 
            // downloadaudiobtn
            // 
            this.downloadaudiobtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.downloadaudiobtn.Location = new System.Drawing.Point(242, 142);
            this.downloadaudiobtn.Name = "downloadaudiobtn";
            this.downloadaudiobtn.Size = new System.Drawing.Size(120, 45);
            this.downloadaudiobtn.TabIndex = 1;
            this.downloadaudiobtn.Text = "Download Audio only";
            this.downloadaudiobtn.UseVisualStyleBackColor = false;
            this.downloadaudiobtn.Click += new System.EventHandler(this.downloadaudiobtn_click);
            // 
            // urltext
            // 
            this.urltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urltext.Location = new System.Drawing.Point(242, 110);
            this.urltext.Name = "urltext";
            this.urltext.Size = new System.Drawing.Size(484, 26);
            this.urltext.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.progressBar1.Location = new System.Drawing.Point(317, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(371, 35);
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Visible = false;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Crimson;
            this.buttonCancel.Location = new System.Drawing.Point(436, 279);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 40);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel Download";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Visible = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // radiobtn360p
            // 
            this.radiobtn360p.AutoSize = true;
            this.radiobtn360p.BackColor = System.Drawing.Color.Transparent;
            this.radiobtn360p.Checked = true;
            this.radiobtn360p.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn360p.Location = new System.Drawing.Point(22, 36);
            this.radiobtn360p.Name = "radiobtn360p";
            this.radiobtn360p.Size = new System.Drawing.Size(55, 21);
            this.radiobtn360p.TabIndex = 8;
            this.radiobtn360p.TabStop = true;
            this.radiobtn360p.Text = "360p";
            this.radiobtn360p.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radiobtn360p.UseVisualStyleBackColor = false;
            this.radiobtn360p.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radiobtn720p
            // 
            this.radiobtn720p.AutoSize = true;
            this.radiobtn720p.BackColor = System.Drawing.Color.Transparent;
            this.radiobtn720p.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn720p.Location = new System.Drawing.Point(22, 63);
            this.radiobtn720p.Name = "radiobtn720p";
            this.radiobtn720p.Size = new System.Drawing.Size(55, 21);
            this.radiobtn720p.TabIndex = 10;
            this.radiobtn720p.Text = "720p";
            this.radiobtn720p.UseVisualStyleBackColor = false;
            this.radiobtn720p.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(421, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enter link";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radiobtn360p);
            this.groupBox1.Controls.Add(this.radiobtn720p);
            this.groupBox1.Controls.Add(this.radiobtn1080p);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(799, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 125);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Video Quality";
            // 
            // radiobtn1080p
            // 
            this.radiobtn1080p.AutoSize = true;
            this.radiobtn1080p.BackColor = System.Drawing.Color.Transparent;
            this.radiobtn1080p.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn1080p.Location = new System.Drawing.Point(22, 90);
            this.radiobtn1080p.Name = "radiobtn1080p";
            this.radiobtn1080p.Size = new System.Drawing.Size(134, 21);
            this.radiobtn1080p.TabIndex = 11;
            this.radiobtn1080p.Text = "1080p(Only Video)";
            this.radiobtn1080p.UseVisualStyleBackColor = false;
            this.radiobtn1080p.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Centaur", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = " Copyright © All Rights Reserved to Tahmid Rahman.";
            // 
            // helpbtn
            // 
            this.helpbtn.BackColor = System.Drawing.Color.PaleVioletRed;
            this.helpbtn.Location = new System.Drawing.Point(101, 1);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(95, 33);
            this.helpbtn.TabIndex = 19;
            this.helpbtn.Text = "Help";
            this.helpbtn.UseVisualStyleBackColor = false;
            this.helpbtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // aboutbtn
            // 
            this.aboutbtn.BackColor = System.Drawing.Color.MediumAquamarine;
            this.aboutbtn.Location = new System.Drawing.Point(0, 1);
            this.aboutbtn.Name = "aboutbtn";
            this.aboutbtn.Size = new System.Drawing.Size(95, 33);
            this.aboutbtn.TabIndex = 20;
            this.aboutbtn.Text = "About";
            this.aboutbtn.UseVisualStyleBackColor = false;
            this.aboutbtn.Click += new System.EventHandler(this.about_Click);
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.closebtn.Location = new System.Drawing.Point(871, 1);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(95, 33);
            this.closebtn.TabIndex = 21;
            this.closebtn.Text = "Close";
            this.closebtn.UseVisualStyleBackColor = false;
            this.closebtn.Click += new System.EventHandler(this.Close_Click);
            // 
            // videoinfobtn
            // 
            this.videoinfobtn.BackColor = System.Drawing.Color.Thistle;
            this.videoinfobtn.Location = new System.Drawing.Point(424, 142);
            this.videoinfobtn.Name = "videoinfobtn";
            this.videoinfobtn.Size = new System.Drawing.Size(127, 45);
            this.videoinfobtn.TabIndex = 22;
            this.videoinfobtn.Text = "Get Video Info";
            this.videoinfobtn.UseVisualStyleBackColor = false;
            this.videoinfobtn.Click += new System.EventHandler(this.videoinfobtn_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(968, 372);
            this.Controls.Add(this.videoinfobtn);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.aboutbtn);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.urltext);
            this.Controls.Add(this.downloadaudiobtn);
            this.Controls.Add(this.downloadvideobtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(984, 411);
            this.MinimumSize = new System.Drawing.Size(984, 411);
            this.Name = "Form1";
            this.Text = "TRL Youtube Downloader";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button downloadvideobtn;
        private System.Windows.Forms.Button downloadaudiobtn;
        private System.Windows.Forms.TextBox urltext;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.RadioButton radiobtn360p;
        private System.Windows.Forms.RadioButton radiobtn720p;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button helpbtn;
        private System.Windows.Forms.Button aboutbtn;
        private System.Windows.Forms.Button closebtn;
        private System.Windows.Forms.RadioButton radiobtn1080p;
        private System.Windows.Forms.Button videoinfobtn;
    }
}

