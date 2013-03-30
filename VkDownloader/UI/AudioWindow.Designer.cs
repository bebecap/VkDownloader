namespace VkDownloader.UI
{
    partial class AudioWindow
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vkSongsList = new System.Windows.Forms.ListBox();
            this.prevBtn = new System.Windows.Forms.Button();
            this.playStopBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.downloadProgress = new System.Windows.Forms.ProgressBar();
            this.libSongsList = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.downloadProgress);
            this.panel1.Controls.Add(this.nextBtn);
            this.panel1.Controls.Add(this.playStopBtn);
            this.panel1.Controls.Add(this.prevBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 69);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.vkSongsList);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 480);
            this.panel2.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(0, 434);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Import";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vkSongsList
            // 
            this.vkSongsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vkSongsList.FormattingEnabled = true;
            this.vkSongsList.Location = new System.Drawing.Point(0, 0);
            this.vkSongsList.Name = "vkSongsList";
            this.vkSongsList.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.vkSongsList.Size = new System.Drawing.Size(200, 434);
            this.vkSongsList.TabIndex = 9;
            // 
            // prevBtn
            // 
            this.prevBtn.Location = new System.Drawing.Point(12, 6);
            this.prevBtn.Name = "prevBtn";
            this.prevBtn.Size = new System.Drawing.Size(75, 23);
            this.prevBtn.TabIndex = 0;
            this.prevBtn.Text = "button2";
            this.prevBtn.UseVisualStyleBackColor = true;
            // 
            // playStopBtn
            // 
            this.playStopBtn.Location = new System.Drawing.Point(93, 6);
            this.playStopBtn.Name = "playStopBtn";
            this.playStopBtn.Size = new System.Drawing.Size(75, 23);
            this.playStopBtn.TabIndex = 1;
            this.playStopBtn.Text = "button3";
            this.playStopBtn.UseVisualStyleBackColor = true;
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(174, 6);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 23);
            this.nextBtn.TabIndex = 2;
            this.nextBtn.Text = "button4";
            this.nextBtn.UseVisualStyleBackColor = true;
            // 
            // downloadProgress
            // 
            this.downloadProgress.Location = new System.Drawing.Point(12, 34);
            this.downloadProgress.Name = "downloadProgress";
            this.downloadProgress.Size = new System.Drawing.Size(753, 23);
            this.downloadProgress.TabIndex = 3;
            // 
            // libSongsList
            // 
            this.libSongsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.libSongsList.FormattingEnabled = true;
            this.libSongsList.Location = new System.Drawing.Point(200, 0);
            this.libSongsList.Name = "libSongsList";
            this.libSongsList.Size = new System.Drawing.Size(577, 480);
            this.libSongsList.TabIndex = 7;
            // 
            // AudioWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 549);
            this.Controls.Add(this.libSongsList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AudioWindow";
            this.Text = "AudioWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.AudioWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox vkSongsList;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button playStopBtn;
        private System.Windows.Forms.Button prevBtn;
        private System.Windows.Forms.ProgressBar downloadProgress;
        private System.Windows.Forms.ListBox libSongsList;
    }
}