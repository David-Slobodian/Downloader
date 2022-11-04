
namespace Downloaderr
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutUsBut = new System.Windows.Forms.Button();
            this.DownloadsButton = new System.Windows.Forms.Button();
            this.AddDownloadPanel = new System.Windows.Forms.Panel();
            this.exampleurl = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.UrlLabel = new System.Windows.Forms.Label();
            this.SelectPathBut = new System.Windows.Forms.Button();
            this.WhereToSaveLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SpeedFirst = new System.Windows.Forms.Label();
            this.SizeDownload = new System.Windows.Forms.Label();
            this.progressBarFirst = new System.Windows.Forms.ProgressBar();
            this.NameDownload = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AddDownloadBut = new System.Windows.Forms.Button();
            this.donateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.AddDownloadPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(63)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.donateButton);
            this.panel1.Controls.Add(this.AboutUsBut);
            this.panel1.Controls.Add(this.DownloadsButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 487);
            this.panel1.TabIndex = 0;
            // 
            // AboutUsBut
            // 
            this.AboutUsBut.Location = new System.Drawing.Point(0, 100);
            this.AboutUsBut.Name = "AboutUsBut";
            this.AboutUsBut.Size = new System.Drawing.Size(180, 31);
            this.AboutUsBut.TabIndex = 2;
            this.AboutUsBut.Text = "About Us";
            this.AboutUsBut.UseVisualStyleBackColor = true;
            this.AboutUsBut.Click += new System.EventHandler(this.AboutUsBut_Click);
            // 
            // DownloadsButton
            // 
            this.DownloadsButton.Location = new System.Drawing.Point(-1, 53);
            this.DownloadsButton.Name = "DownloadsButton";
            this.DownloadsButton.Size = new System.Drawing.Size(180, 31);
            this.DownloadsButton.TabIndex = 0;
            this.DownloadsButton.Text = "Downloads";
            this.DownloadsButton.UseVisualStyleBackColor = true;
            // 
            // AddDownloadPanel
            // 
            this.AddDownloadPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AddDownloadPanel.Controls.Add(this.exampleurl);
            this.AddDownloadPanel.Controls.Add(this.AddButton);
            this.AddDownloadPanel.Controls.Add(this.CancelButton);
            this.AddDownloadPanel.Controls.Add(this.urlTextBox);
            this.AddDownloadPanel.Controls.Add(this.UrlLabel);
            this.AddDownloadPanel.Controls.Add(this.SelectPathBut);
            this.AddDownloadPanel.Controls.Add(this.WhereToSaveLabel);
            this.AddDownloadPanel.Location = new System.Drawing.Point(395, 0);
            this.AddDownloadPanel.Name = "AddDownloadPanel";
            this.AddDownloadPanel.Size = new System.Drawing.Size(276, 188);
            this.AddDownloadPanel.TabIndex = 8;
            // 
            // exampleurl
            // 
            this.exampleurl.AutoSize = true;
            this.exampleurl.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exampleurl.Location = new System.Drawing.Point(4, 102);
            this.exampleurl.Name = "exampleurl";
            this.exampleurl.Size = new System.Drawing.Size(203, 13);
            this.exampleurl.TabIndex = 7;
            this.exampleurl.Text = "(e.g - http://212.183.159.230/20MB.zip)";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(148, 129);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(117, 33);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(13, 130);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(117, 33);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(48, 77);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(184, 23);
            this.urlTextBox.TabIndex = 4;
            // 
            // UrlLabel
            // 
            this.UrlLabel.AutoSize = true;
            this.UrlLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UrlLabel.Location = new System.Drawing.Point(3, 75);
            this.UrlLabel.Name = "UrlLabel";
            this.UrlLabel.Size = new System.Drawing.Size(39, 21);
            this.UrlLabel.TabIndex = 3;
            this.UrlLabel.Text = "URL";
            // 
            // SelectPathBut
            // 
            this.SelectPathBut.Location = new System.Drawing.Point(127, 26);
            this.SelectPathBut.Name = "SelectPathBut";
            this.SelectPathBut.Size = new System.Drawing.Size(113, 28);
            this.SelectPathBut.TabIndex = 2;
            this.SelectPathBut.Text = "Select folder";
            this.SelectPathBut.UseVisualStyleBackColor = true;
            this.SelectPathBut.Click += new System.EventHandler(this.SelectPathBut_Click);
            // 
            // WhereToSaveLabel
            // 
            this.WhereToSaveLabel.AutoSize = true;
            this.WhereToSaveLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WhereToSaveLabel.Location = new System.Drawing.Point(3, 28);
            this.WhereToSaveLabel.Name = "WhereToSaveLabel";
            this.WhereToSaveLabel.Size = new System.Drawing.Size(118, 21);
            this.WhereToSaveLabel.TabIndex = 1;
            this.WhereToSaveLabel.Text = "Path to save file";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.SpeedFirst);
            this.panel2.Controls.Add(this.SizeDownload);
            this.panel2.Controls.Add(this.progressBarFirst);
            this.panel2.Controls.Add(this.NameDownload);
            this.panel2.Controls.Add(this.SpeedLabel);
            this.panel2.Controls.Add(this.StatusLabel);
            this.panel2.Controls.Add(this.SizeLabel);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Location = new System.Drawing.Point(186, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 447);
            this.panel2.TabIndex = 12;
            // 
            // SpeedFirst
            // 
            this.SpeedFirst.AutoSize = true;
            this.SpeedFirst.Location = new System.Drawing.Point(578, 39);
            this.SpeedFirst.Name = "SpeedFirst";
            this.SpeedFirst.Size = new System.Drawing.Size(45, 15);
            this.SpeedFirst.TabIndex = 7;
            this.SpeedFirst.Text = "Speed1";
            // 
            // SizeDownload
            // 
            this.SizeDownload.Location = new System.Drawing.Point(193, 39);
            this.SizeDownload.Name = "SizeDownload";
            this.SizeDownload.Size = new System.Drawing.Size(85, 46);
            this.SizeDownload.TabIndex = 5;
            this.SizeDownload.Text = "Size1";
            // 
            // progressBarFirst
            // 
            this.progressBarFirst.BackColor = System.Drawing.SystemColors.Control;
            this.progressBarFirst.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBarFirst.Location = new System.Drawing.Point(332, 31);
            this.progressBarFirst.Name = "progressBarFirst";
            this.progressBarFirst.Size = new System.Drawing.Size(162, 23);
            this.progressBarFirst.TabIndex = 6;
            // 
            // NameDownload
            // 
            this.NameDownload.AutoSize = true;
            this.NameDownload.Location = new System.Drawing.Point(6, 39);
            this.NameDownload.Name = "NameDownload";
            this.NameDownload.Size = new System.Drawing.Size(45, 15);
            this.NameDownload.TabIndex = 4;
            this.NameDownload.Text = "Name1";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(578, 9);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(39, 15);
            this.SpeedLabel.TabIndex = 3;
            this.SpeedLabel.Text = "Speed";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(387, 9);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(39, 15);
            this.StatusLabel.TabIndex = 2;
            this.StatusLabel.Text = "Status";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(218, 9);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(27, 15);
            this.SizeLabel.TabIndex = 1;
            this.SizeLabel.Text = "Size";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(7, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 15);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // AddDownloadBut
            // 
            this.AddDownloadBut.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddDownloadBut.Location = new System.Drawing.Point(194, 0);
            this.AddDownloadBut.Name = "AddDownloadBut";
            this.AddDownloadBut.Size = new System.Drawing.Size(25, 23);
            this.AddDownloadBut.TabIndex = 13;
            this.AddDownloadBut.Text = "+";
            this.AddDownloadBut.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddDownloadBut.UseVisualStyleBackColor = true;
            this.AddDownloadBut.Click += new System.EventHandler(this.AddDownloadBut_Click);
            // 
            // donateButton
            // 
            this.donateButton.Location = new System.Drawing.Point(-1, 146);
            this.donateButton.Name = "donateButton";
            this.donateButton.Size = new System.Drawing.Size(180, 31);
            this.donateButton.TabIndex = 3;
            this.donateButton.Text = "Donate";
            this.donateButton.UseVisualStyleBackColor = true;
            this.donateButton.Click += new System.EventHandler(this.donateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(867, 488);
            this.Controls.Add(this.AddDownloadBut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AddDownloadPanel);
            this.Name = "Form1";
            this.Text = "Downloader";
            this.panel1.ResumeLayout(false);
            this.AddDownloadPanel.ResumeLayout(false);
            this.AddDownloadPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button AboutUsBut;
        private System.Windows.Forms.Button DownloadsButton;
        public System.Windows.Forms.Label SpeedFirst;
        public System.Windows.Forms.ProgressBar progressBarFirst;
        public System.Windows.Forms.Label SizeDownload;
        public System.Windows.Forms.Label NameDownload;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AddDownloadBut;
        private System.Windows.Forms.Panel AddDownloadPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button CancelButton;
        public System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label UrlLabel;
        public System.Windows.Forms.Button SelectPathBut;
        private System.Windows.Forms.Label WhereToSaveLabel;
        public System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label exampleurl;
        public System.Windows.Forms.Button donateButton;
    }
}

