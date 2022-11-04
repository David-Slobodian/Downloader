
namespace Downloaderr
{
    partial class AboutUs
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
            this.label = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(1, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(388, 75);
            this.label.TabIndex = 0;
            this.label.Text = "This simple downloader was made by David with the purpose of practice\r\nMy experie" +
    "nce is 3 months\r\n\r\nInstagram: @dav_idsl12\r\nTelegram: @imdavids\r\n";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(115, 93);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(147, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AboutUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 128);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.label);
            this.Name = "AboutUs";
            this.Text = "AboutUs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button OkButton;
    }
}