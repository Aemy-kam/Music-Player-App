namespace MusicPlayerApp
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblLogo = new System.Windows.Forms.Label();
            this.listBoxSongs = new System.Windows.Forms.ListBox();
            this.btnSelectSongs = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayerMusic = new AxWMPLib.AxWindowsMediaPlayer();
            this.fav_btn = new System.Windows.Forms.Button();
            this.fav_box = new System.Windows.Forms.ListBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.OldLace;
            this.TopPanel.Controls.Add(this.pictureBox1);
            this.TopPanel.Controls.Add(this.lblLogo);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(876, 35);
            this.TopPanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(842, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblLogo.Location = new System.Drawing.Point(4, 1);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(184, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "Music Player App";
            // 
            // listBoxSongs
            // 
            this.listBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxSongs.FormattingEnabled = true;
            this.listBoxSongs.ItemHeight = 16;
            this.listBoxSongs.Location = new System.Drawing.Point(485, 74);
            this.listBoxSongs.Name = "listBoxSongs";
            this.listBoxSongs.Size = new System.Drawing.Size(183, 276);
            this.listBoxSongs.TabIndex = 1;
            this.listBoxSongs.SelectedIndexChanged += new System.EventHandler(this.listBoxSongs_SelectedIndexChanged);
            // 
            // btnSelectSongs
            // 
            this.btnSelectSongs.BackColor = System.Drawing.Color.DimGray;
            this.btnSelectSongs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectSongs.ForeColor = System.Drawing.Color.White;
            this.btnSelectSongs.Location = new System.Drawing.Point(485, 354);
            this.btnSelectSongs.Name = "btnSelectSongs";
            this.btnSelectSongs.Size = new System.Drawing.Size(92, 49);
            this.btnSelectSongs.TabIndex = 2;
            this.btnSelectSongs.Text = "Select Songs";
            this.btnSelectSongs.UseVisualStyleBackColor = false;
            this.btnSelectSongs.Click += new System.EventHandler(this.btnSelectSongs_Click);
            // 
            // axWindowsMediaPlayerMusic
            // 
            this.axWindowsMediaPlayerMusic.Enabled = true;
            this.axWindowsMediaPlayerMusic.Location = new System.Drawing.Point(7, 74);
            this.axWindowsMediaPlayerMusic.Name = "axWindowsMediaPlayerMusic";
            this.axWindowsMediaPlayerMusic.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerMusic.OcxState")));
            this.axWindowsMediaPlayerMusic.Size = new System.Drawing.Size(467, 328);
            this.axWindowsMediaPlayerMusic.TabIndex = 3;
            // 
            // fav_btn
            // 
            this.fav_btn.BackColor = System.Drawing.Color.Black;
            this.fav_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fav_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.fav_btn.Location = new System.Drawing.Point(583, 353);
            this.fav_btn.Name = "fav_btn";
            this.fav_btn.Size = new System.Drawing.Size(85, 49);
            this.fav_btn.TabIndex = 5;
            this.fav_btn.Text = "Add to fav";
            this.fav_btn.UseVisualStyleBackColor = false;
            this.fav_btn.Click += new System.EventHandler(this.fav_btn_Click);
            // 
            // fav_box
            // 
            this.fav_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fav_box.FormattingEnabled = true;
            this.fav_box.ItemHeight = 16;
            this.fav_box.Location = new System.Drawing.Point(684, 74);
            this.fav_box.Name = "fav_box";
            this.fav_box.Size = new System.Drawing.Size(183, 292);
            this.fav_box.TabIndex = 4;
            this.fav_box.SelectedIndexChanged += new System.EventHandler(this.fav_box_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(684, 373);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(183, 29);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete Song";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(5, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "Player";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(483, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Music List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(680, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Favorite List";
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(876, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.fav_btn);
            this.Controls.Add(this.fav_box);
            this.Controls.Add(this.axWindowsMediaPlayerMusic);
            this.Controls.Add(this.btnSelectSongs);
            this.Controls.Add(this.listBoxSongs);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerMusic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.ListBox listBoxSongs;
        private System.Windows.Forms.Button btnSelectSongs;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerMusic;
        private System.Windows.Forms.Button fav_btn;
        private System.Windows.Forms.ListBox fav_box;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

