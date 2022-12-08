namespace m10-lab-ali
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
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.LBL_songTitle = new System.Windows.Forms.Label();
            this.LBL_singer = new System.Windows.Forms.Label();
            this.txt_singer = new System.Windows.Forms.TextBox();
            this.LBL_album = new System.Windows.Forms.Label();
            this.txt_album = new System.Windows.Forms.TextBox();
            this.btn_createSong = new System.Windows.Forms.Button();
            this.lst_songs = new System.Windows.Forms.ListBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_ssinger = new System.Windows.Forms.Label();
            this.lbl_salbum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(67, 73);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(200, 27);
            this.txt_songTitle.TabIndex = 0;
            // 
            // LBL_songTitle
            // 
            this.LBL_songTitle.AutoSize = true;
            this.LBL_songTitle.Location = new System.Drawing.Point(67, 41);
            this.LBL_songTitle.Name = "LBL_songTitle";
            this.LBL_songTitle.Size = new System.Drawing.Size(79, 20);
            this.LBL_songTitle.TabIndex = 1;
            this.LBL_songTitle.Text = "Song Title:";
            // 
            // LBL_singer
            // 
            this.LBL_singer.AutoSize = true;
            this.LBL_singer.Location = new System.Drawing.Point(67, 128);
            this.LBL_singer.Name = "LBL_singer";
            this.LBL_singer.Size = new System.Drawing.Size(54, 20);
            this.LBL_singer.TabIndex = 3;
            this.LBL_singer.Text = "Singer:";
            // 
            // txt_singer
            // 
            this.txt_singer.Location = new System.Drawing.Point(67, 160);
            this.txt_singer.Name = "txt_singer";
            this.txt_singer.Size = new System.Drawing.Size(200, 27);
            this.txt_singer.TabIndex = 2;
            // 
            // LBL_album
            // 
            this.LBL_album.AutoSize = true;
            this.LBL_album.Location = new System.Drawing.Point(67, 218);
            this.LBL_album.Name = "LBL_album";
            this.LBL_album.Size = new System.Drawing.Size(56, 20);
            this.LBL_album.TabIndex = 5;
            this.LBL_album.Text = "Album:";
            // 
            // txt_album
            // 
            this.txt_album.Location = new System.Drawing.Point(67, 250);
            this.txt_album.Name = "txt_album";
            this.txt_album.Size = new System.Drawing.Size(200, 27);
            this.txt_album.TabIndex = 4;
            // 
            // btn_createSong
            // 
            this.btn_createSong.Location = new System.Drawing.Point(159, 306);
            this.btn_createSong.Name = "btn_createSong";
            this.btn_createSong.Size = new System.Drawing.Size(108, 29);
            this.btn_createSong.TabIndex = 6;
            this.btn_createSong.Text = "Create Song";
            this.btn_createSong.UseVisualStyleBackColor = true;
            this.btn_createSong.Click += new System.EventHandler(this.btn_createSong_Click);
            // 
            // lst_songs
            // 
            this.lst_songs.FormattingEnabled = true;
            this.lst_songs.ItemHeight = 20;
            this.lst_songs.Location = new System.Drawing.Point(314, 41);
            this.lst_songs.Name = "lst_songs";
            this.lst_songs.Size = new System.Drawing.Size(210, 284);
            this.lst_songs.TabIndex = 7;
            this.lst_songs.SelectedIndexChanged += new System.EventHandler(this.lst_songs_SelectedIndexChanged);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(551, 41);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(168, 20);
            this.lbl_title.TabIndex = 8;
            this.lbl_title.Text = "Title will be shown here.";
            // 
            // lbl_ssinger
            // 
            this.lbl_ssinger.AutoSize = true;
            this.lbl_ssinger.Location = new System.Drawing.Point(551, 115);
            this.lbl_ssinger.Name = "lbl_ssinger";
            this.lbl_ssinger.Size = new System.Drawing.Size(181, 20);
            this.lbl_ssinger.TabIndex = 9;
            this.lbl_ssinger.Text = "Singer will be shown here.";
            // 
            // lbl_salbum
            // 
            this.lbl_salbum.AutoSize = true;
            this.lbl_salbum.Location = new System.Drawing.Point(551, 187);
            this.lbl_salbum.Name = "lbl_salbum";
            this.lbl_salbum.Size = new System.Drawing.Size(183, 20);
            this.lbl_salbum.TabIndex = 10;
            this.lbl_salbum.Text = "Album will be shown here.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 400);
            this.Controls.Add(this.lbl_salbum);
            this.Controls.Add(this.lbl_ssinger);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lst_songs);
            this.Controls.Add(this.btn_createSong);
            this.Controls.Add(this.LBL_album);
            this.Controls.Add(this.txt_album);
            this.Controls.Add(this.LBL_singer);
            this.Controls.Add(this.txt_singer);
            this.Controls.Add(this.LBL_songTitle);
            this.Controls.Add(this.txt_songTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txt_songTitle;
        private Label LBL_songTitle;
        private Label LBL_singer;
        private TextBox txt_singer;
        private Label LBL_album;
        private TextBox txt_album;
        private Button btn_createSong;
        private ListBox lst_songs;
        private Label lbl_title;
        private Label lbl_ssinger;
        private Label lbl_salbum;
    }
}