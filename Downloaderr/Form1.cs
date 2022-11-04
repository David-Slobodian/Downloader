using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Downloaderr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //Turning off items
            NameDownload.Visible = false;
            SizeDownload.Visible = false;
            progressBarFirst.Visible = false;
            SpeedFirst.Visible = false;

            AddDownloadPanel.Visible = false;
            AddDownloadBut.Enabled = true;



            //Inserting pictures before text
            progressBarFirst.ForeColor = Color.Blue;


            var picture = new Bitmap(
                Downloaderr.Properties.Resources.download_icon,
                new Size(15, 15));

            DownloadsButton.Image = picture;
            DownloadsButton.ImageAlign = ContentAlignment.MiddleLeft;
            DownloadsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DownloadsButton.TextAlign = ContentAlignment.MiddleLeft;

            picture = new Bitmap(
                Downloaderr.Properties.Resources.info_icon,
                new Size(15, 15));

            AboutUsBut.Image = picture;
            AboutUsBut.ImageAlign = ContentAlignment.MiddleLeft;
            AboutUsBut.TextImageRelation = TextImageRelation.ImageBeforeText;
            AboutUsBut.TextAlign = ContentAlignment.MiddleLeft;

            picture = new Bitmap(
                Downloaderr.Properties.Resources.add_download_img,
                new Size(15, 15));
            AddDownloadBut.Image = picture;
            AddDownloadBut.ImageAlign = ContentAlignment.MiddleCenter;
            AddDownloadBut.TextImageRelation = TextImageRelation.Overlay;

            picture = new Bitmap(
                Downloaderr.Properties.Resources.donateimg,
                new Size(20, 20));
            donateButton.Image = picture;
            donateButton.ImageAlign = ContentAlignment.MiddleLeft;
            donateButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            donateButton.TextAlign = ContentAlignment.MiddleLeft;
        }

        //Variables
        Size SizeOfMainForm = new();
        string folderPath = string.Empty;
        DialogResult result = new();
        FolderBrowserDialog folderDlg = new();
        System.Diagnostics.Stopwatch stopwatch = new();
        private void AddDownloadBut_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            AddDownloadBut.Visible = false;

            AddDownloadPanel.Location = new Point(0, 0);
            SizeOfMainForm = this.Size;
            this.Size = new Size(AddDownloadPanel.Width + 18, AddDownloadPanel.Height + 30);
            AddDownloadPanel.Visible = true;

            //
            NameDownload.Text = "";
            SizeDownload.Text = "";
            SpeedFirst.Text = "";
            progressBarFirst.Value = 0;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddDownloadPanel.Visible = false;


            result = DialogResult.No;
            folderPath = string.Empty;
            SelectPathBut.Text = "Select folder";
            urlTextBox.Text = string.Empty;

            panel1.Visible = true;
            panel2.Visible = true;
            AddDownloadBut.Visible = true;
            this.Size = SizeOfMainForm;
        }

        private void SelectPathBut_Click(object sender, EventArgs e)
        {
            folderDlg = new FolderBrowserDialog();

            result = folderDlg.ShowDialog();
            if (result == DialogResult.OK)
            {
                folderPath = folderDlg.SelectedPath;
                SelectPathBut.Text = "Selected";
            }
            else
            {
                MessageBox.Show("Something went wrong. Select path again", "Path Error");
            }
        }
        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(urlTextBox.Text)
                && result == DialogResult.OK
                && urlTextBox.Text.Contains('/')
                && urlTextBox.Text.Contains('.')
                && urlTextBox.Text.Length > 2
               )
            {
                #region returning default values
                AddDownloadPanel.Visible = false;

                SelectPathBut.Text = "Select folder";

                panel1.Visible = true;
                panel2.Visible = true;
                AddDownloadBut.Visible = true;
                this.Size = SizeOfMainForm;
                #endregion

                using (WebClient wc = new())
                {
                    wc.DownloadProgressChanged += (sender, e) =>
                    {
                        int size = (int)e.TotalBytesToReceive;
                        double b = size;
                        double k = size / 1024.0;
                        double m = ((size / 1024.0) / 1024.0);
                        double g = (((size / 1024.0) / 1024.0) / 1024.0);
                        double t = ((((size / 1024.0) / 1024.0) / 1024.0) / 1024.0);

                        if (t >= 1)
                        {
                            SizeDownload.Text = $"{(int)((((e.BytesReceived / 1024.0) / 1024.0) / 1024.0) / 1024.0)} / {t} TB";
                        }
                        else if (g >= 1)
                        {
                            SizeDownload.Text = $"{(int)(((e.BytesReceived / 1024.0) / 1024.0) / 1024.0)} / {g} GB";
                        }
                        else if (m >= 1)
                        {
                            SizeDownload.Text = $"{(int)((e.BytesReceived / 1024.0) / 1024.0)} / {m} MB";
                        }
                        else if (k >= 1)
                        {
                            SizeDownload.Text = $"{(int)e.BytesReceived / 1024.0} / {k} KB";
                        }
                        else
                        {
                            SizeDownload.Text = $"{e.BytesReceived} / {e.TotalBytesToReceive} B";
                        }

                        progressBarFirst.Value = e.ProgressPercentage;
                        SizeDownload.Text += $"\n({e.ProgressPercentage} %)";
                        AddDownloadBut.Enabled = false;

                    };

                    NameDownload.Visible = true;
                    SizeDownload.Visible = true;
                    progressBarFirst.Visible = true;
                    SpeedFirst.Visible = true;

                    wc.DownloadProgressChanged += OnDownloadProgressChange;
                    wc.DownloadFileCompleted += OnDownloadFileComplete;

                    //URL
                    if(!urlTextBox.Text.Contains("http://") || !urlTextBox.Text.Contains("https://"))
                    {
                        string temp = urlTextBox.Text;
                        urlTextBox.Text = "http://";
                        urlTextBox.Text += temp;
                    }

                    //File name + path

                    string filename = urlTextBox.Text.Split('/').Last();
                    folderPath += "\\";
                    string savePath = folderPath + filename;
                    folderPath = string.Empty;

                   // NameDownload.Visible = true;
                    NameDownload.Text = filename;


                    stopwatch.Start();
                    wc.DownloadFileAsync(new System.Uri(urlTextBox.Text), savePath);

                    //Speed
                    //SpeedFirst.Visible = true;

                    wc.DownloadFileCompleted += (sender, o) =>
                    {
                        progressBarFirst.Value = 0;

                        urlTextBox.Text = string.Empty;
                        progressBarFirst.Value = 0;
                        MessageBox.Show("Done", "Download");
                        AddDownloadBut.Enabled = true;
                    };
                }
            }
            else
                MessageBox.Show("Please check inputted entries and try again", "DATA ERROR");
        }
        private void OnDownloadProgressChange(object sender, DownloadProgressChangedEventArgs e)
        {
            SpeedFirst.Text = string.Format("{0} MB/s", (e.BytesReceived / 1024.0 / 1024.0 / stopwatch.Elapsed.TotalSeconds).ToString("0.00"));
        }
        
        private void OnDownloadFileComplete(object sender, AsyncCompletedEventArgs e)
        {
            stopwatch.Reset();
        }

        private void AboutUsBut_Click(object sender, EventArgs e)
        {
            AboutUs aboutUs = new();
            aboutUs.Show();
        }

        private void donateButton_Click(object sender, EventArgs e)
        {
            string url = "https://www.paypal.com/donate/?hosted_button_id=9CTM9DJJ6GGVL";

            try
            {
                Process.Start(url);
            }
            catch
            {

                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
