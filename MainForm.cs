using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using YoutubeExtractor;
using System.Text.RegularExpressions;
using System.IO;




namespace YoutubeDownloaderWindowsForm
{
    public partial class MainForm : Form
    {
        static int flag = 1;
        public static int messagebox = 1;
        int res = 360;
        string S;
        private BackgroundWorker bw = new BackgroundWorker();
        public MainForm()
        {
            InitializeComponent();
            radiobtn360p.Enabled = false;
            radiobtn720p.Enabled = false;
            radiobtn1080p.Enabled = false;
            downloadvideobtn.Visible = false;
            downloadaudiobtn.Visible= false;
            bw.WorkerReportsProgress = true;
            bw.WorkerSupportsCancellation = true;
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.ProgressChanged += new ProgressChangedEventHandler(bw_ProgressChanged);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
        }
        private void DownloadAudio(IEnumerable<VideoInfo> videoInfos)
        {
            

            try
            {

                VideoInfo video = videoInfos
                    .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == 0);

                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);

                }

                try
                {
                    var videoDownloader = new VideoDownloader(video,
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    RemoveIllegalPathCharacters(video.Title) + ".mp3"));
                    S = RemoveIllegalPathCharacters(video.Title) + ".mp3";
                        //video.VideoExtension;
                    double x = Convert.ToDouble(videoDownloader.BytesToDownload);



                    videoDownloader.DownloadProgressChanged += (sender, args) => bw.ReportProgress(Convert.ToInt32(args.ProgressPercentage));
                    // label3.Text = videoDownloader.BytesToDownload.ToString();
                    videoDownloader.Execute();
                    MessageBox.Show("Audio Download Completed on your Desktop");
                    Application.Restart();
                    bw.ReportProgress(0);

                }
                catch (Exception exe)
                {
                    MessageBox.Show("An error has occured while downloading this audio.This might be because of problems in your network connection");
                    Application.Restart();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Error Occured");
                Application.Restart();

            }

            /*
                        try
                        {
                            VideoInfo video = videoInfos
                                .Where(info => info.CanExtractAudio)
                                .OrderByDescending(info => info.AudioBitrate)
                                .First();


                            if (video.RequiresDecryption)
                            {
                                DownloadUrlResolver.DecryptDownloadUrl(video);
                            }

                            var audioDownloader = new AudioDownloader(video,
                            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                            RemoveIllegalPathCharacters(video.Title) + video.AudioExtension));
                            S = RemoveIllegalPathCharacters(video.Title) + video.AudioExtension;
                        //    label3.Text = S;

                            audioDownloader.DownloadProgressChanged += (sender, args) => bw.ReportProgress(Convert.ToInt32(args.ProgressPercentage));
                            audioDownloader.Execute();

                            MessageBox.Show("Audio Download Completed on your Desktop");
                            Application.Restart();
                            bw.ReportProgress(0);
                        }
                        catch(Exception ex)
                        {
                          // 

                            MessageBox.Show("There is error downloading the audio");
                            Application.Restart();

                        }
              */

        }

        private void DownloadVideo(IEnumerable<VideoInfo> videoInfos)
        {
           
            try
            {
                
                VideoInfo video = videoInfos
                    .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == res);
             
                if (video.RequiresDecryption)
                {
                    DownloadUrlResolver.DecryptDownloadUrl(video);
                    
                }

                try
                {
                    var videoDownloader = new VideoDownloader(video,
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
                    RemoveIllegalPathCharacters(video.Title) + video.VideoExtension));
                    S = RemoveIllegalPathCharacters(video.Title) + video.VideoExtension;
                    double x = Convert.ToDouble(videoDownloader.BytesToDownload);
                  
             
          
                    videoDownloader.DownloadProgressChanged += (sender, args) => bw.ReportProgress(Convert.ToInt32(args.ProgressPercentage));
                   // label3.Text = videoDownloader.BytesToDownload.ToString();
                    videoDownloader.Execute();
                    MessageBox.Show("Video Download Completed on your Desktop");
                    Application.Restart();
                    bw.ReportProgress(0);
                   
                }
                catch(Exception exe)
                {
                    MessageBox.Show("An error has occured while downloading this video.This might be because of problems in your network connection");
                    Application.Restart();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(res.ToString() + "p not supported by this video");
                Application.Restart();

            }
            
        }

        private void func(int val)
        {
      
            string link = urltext.Text;
            try
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);
            
                if (val == 2)
                    DownloadAudio(videoInfos);
                else
                    DownloadVideo(videoInfos);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid link");
                Application.Restart();

            }
          
        }

        private static string RemoveIllegalPathCharacters(string path)
        {
            string regexSearch = new string(Path.GetInvalidFileNameChars()) + new string(Path.GetInvalidPathChars());
            var r = new Regex(string.Format("[{0}]", Regex.Escape(regexSearch)));
            return r.Replace(path, "");
        }

        private void downloadvideobtn_click(object sender, EventArgs e)
        {
            bw.ReportProgress(0);
          //  if (radioButton1.Checked) res = 144;
          //  if (radioButton2.Checked) res = 240;
            if (radiobtn360p.Checked) res = 360;
        //    if (radioButton4.Checked) res = 480;
            if (radiobtn720p.Checked) res = 720;
            if (radiobtn1080p.Checked) res = 1080;
            downloadvideobtn.Enabled = false;
            downloadaudiobtn.Enabled = false;
            aboutbtn.Enabled = false;
            helpbtn.Enabled = false;
            closebtn.Enabled = false;
            buttonCancel.Visible = true;
            buttonCancel.Enabled= true;
            progressBar1.Visible = true;
            urltext.Enabled = false;
          //  radioButton1.Enabled = false;
          //  radioButton2.Enabled = false;
            radiobtn360p.Enabled = false;
          //  radioButton4.Enabled = false;
            radiobtn720p.Enabled = false;
            radiobtn1080p.Enabled = false;
            if (bw.IsBusy != true)
            {
                flag = 1;
                bw.RunWorkerAsync();
            }
 
        }

        private void downloadaudiobtn_click(object sender, EventArgs e)
        {
            downloadvideobtn.Enabled = false;
            downloadaudiobtn.Enabled = false;
            aboutbtn.Enabled = false;
            helpbtn.Enabled = false;
            closebtn.Enabled = false;
            buttonCancel.Enabled = true;
            buttonCancel.Visible = true;
            progressBar1.Visible = true;
            urltext.Enabled = false;
         //   radioButton1.Enabled = false;
          //  radioButton2.Enabled = false;
            radiobtn360p.Enabled = false;
         //   radioButton4.Enabled = false;
            radiobtn720p.Enabled = false;
            radiobtn1080p.Enabled = false;
            if (bw.IsBusy != true)
            {
                flag = 2;
                bw.RunWorkerAsync();
               
            }
 
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {

            if (flag == 1)
                func(1);
            else func(2);

          
           
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            downloadvideobtn.Enabled = true;
            downloadaudiobtn.Enabled = true;
            aboutbtn.Enabled = true;
            helpbtn.Enabled = true;
            closebtn.Enabled = true;
            buttonCancel.Visible = false;
            progressBar1.Visible = false;
            if ((e.Cancelled == true))
            {
             
            }

            else if (!(e.Error == null))
            {
               
            }

            else
            {
            
            }
        }
        private void bw_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
          //  label3.Text = S;
          progressBar1.Value = (e.ProgressPercentage);
            if(flag==1)
          label1.Text = "Video Downloading: "+e.ProgressPercentage.ToString() + "%"+ " completed";
            else
                label1.Text = "Audio Downloading: " + e.ProgressPercentage.ToString() + "%" + " completed";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            bw.WorkerSupportsCancellation = true;
             if (bw.WorkerSupportsCancellation == true)
            {
              bw.CancelAsync();
              Application.Restart();
            }
            
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void about_Click(object sender, EventArgs e)
        {
           
            AboutForm ob = new AboutForm();
            ob.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelpForm ob = new HelpForm();
            ob.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void videoinfobtn_click(object sender, EventArgs e)
        {
   
            videoinfobtn.Enabled = false;
            int xx;
           
             string link = urltext.Text;
            try
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link, false);
             
                int[] arr = new int[3] { 360, 720, 1080 };
                for (xx = 0; xx < 3; xx++)
                {
                    try
                    {
                        VideoInfo video = videoInfos
                                           .First(info => info.VideoType == VideoType.Mp4 && info.Resolution == arr[xx]);
                        if (xx == 0) radiobtn360p.Enabled = true;
                        else if (xx == 1) radiobtn720p.Enabled = true;
                        else if (xx == 2) radiobtn1080p.Enabled = true;
                       
                    }
                    catch(Exception st)
                    {

                    }
                    
                   
                }
                downloadvideobtn.Visible = true;
                downloadaudiobtn.Visible = true;
                videoinfobtn.Visible = false;
             //   button6.Visible = false;
                VideoInfo vid = videoInfos.First();
                label3.Text = vid.Title;
                 
            }
            catch(Exception exx)
            {
                MessageBox.Show("Invalid link");
                Application.Restart();
            }
           
        
        }

      
    }

    }

