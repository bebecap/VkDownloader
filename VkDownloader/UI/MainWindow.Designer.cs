namespace VkDownloader.UI
{
    partial class MainWindow
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
            this.audioBtn = new System.Windows.Forms.Button();
            this.photoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // audioBtn
            // 
            this.audioBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.audioBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.audioBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.audioBtn.Location = new System.Drawing.Point(0, 0);
            this.audioBtn.Name = "audioBtn";
            this.audioBtn.Size = new System.Drawing.Size(320, 46);
            this.audioBtn.TabIndex = 0;
            this.audioBtn.Text = "Audio";
            this.audioBtn.UseVisualStyleBackColor = true;
            this.audioBtn.Click += new System.EventHandler(this.audioBtn_Click);
            // 
            // photoBtn
            // 
            this.photoBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.photoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.photoBtn.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.photoBtn.Location = new System.Drawing.Point(0, 46);
            this.photoBtn.Name = "photoBtn";
            this.photoBtn.Size = new System.Drawing.Size(320, 46);
            this.photoBtn.TabIndex = 1;
            this.photoBtn.Text = "Photo";
            this.photoBtn.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 157);
            this.Controls.Add(this.photoBtn);
            this.Controls.Add(this.audioBtn);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_FormClosed);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button audioBtn;
        private System.Windows.Forms.Button photoBtn;
    }
}