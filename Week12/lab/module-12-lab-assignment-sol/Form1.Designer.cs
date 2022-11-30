
namespace Module12_home
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabpage_album = new System.Windows.Forms.TabPage();
            this.dtp_yearReleased = new System.Windows.Forms.DateTimePicker();
            this.lbl_albumMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_albumName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_createAlbum = new System.Windows.Forms.Button();
            this.tabpage_songs = new System.Windows.Forms.TabPage();
            this.lbl_songMessage = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_albums = new System.Windows.Forms.ComboBox();
            this.txt_songLength = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_songTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_createSong = new System.Windows.Forms.Button();
            this.tabpage_albumsSongs = new System.Windows.Forms.TabPage();
            this.txt_deleteSong = new System.Windows.Forms.Button();
            this.btn_showSongs = new System.Windows.Forms.Button();
            this.lst_songs = new System.Windows.Forms.ListBox();
            this.lst_albums = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabpage_album.SuspendLayout();
            this.tabpage_songs.SuspendLayout();
            this.tabpage_albumsSongs.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabpage_album);
            this.tabControl1.Controls.Add(this.tabpage_songs);
            this.tabControl1.Controls.Add(this.tabpage_albumsSongs);
            this.tabControl1.Location = new System.Drawing.Point(33, 40);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(421, 316);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabpage_album
            // 
            this.tabpage_album.Controls.Add(this.dtp_yearReleased);
            this.tabpage_album.Controls.Add(this.lbl_albumMessage);
            this.tabpage_album.Controls.Add(this.label2);
            this.tabpage_album.Controls.Add(this.txt_albumName);
            this.tabpage_album.Controls.Add(this.label1);
            this.tabpage_album.Controls.Add(this.btn_createAlbum);
            this.tabpage_album.Location = new System.Drawing.Point(4, 29);
            this.tabpage_album.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpage_album.Name = "tabpage_album";
            this.tabpage_album.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpage_album.Size = new System.Drawing.Size(413, 283);
            this.tabpage_album.TabIndex = 0;
            this.tabpage_album.Text = "Manage Albums";
            this.tabpage_album.UseVisualStyleBackColor = true;
            // 
            // dtp_yearReleased
            // 
            this.dtp_yearReleased.Location = new System.Drawing.Point(133, 97);
            this.dtp_yearReleased.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_yearReleased.Name = "dtp_yearReleased";
            this.dtp_yearReleased.Size = new System.Drawing.Size(158, 27);
            this.dtp_yearReleased.TabIndex = 6;
            // 
            // lbl_albumMessage
            // 
            this.lbl_albumMessage.AutoSize = true;
            this.lbl_albumMessage.Location = new System.Drawing.Point(29, 221);
            this.lbl_albumMessage.Name = "lbl_albumMessage";
            this.lbl_albumMessage.Size = new System.Drawing.Size(221, 20);
            this.lbl_albumMessage.TabIndex = 5;
            this.lbl_albumMessage.Text = "Fill the form to create an album.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Release Date :";
            // 
            // txt_albumName
            // 
            this.txt_albumName.Location = new System.Drawing.Point(133, 41);
            this.txt_albumName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_albumName.Name = "txt_albumName";
            this.txt_albumName.Size = new System.Drawing.Size(158, 27);
            this.txt_albumName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Album Name : ";
            // 
            // btn_createAlbum
            // 
            this.btn_createAlbum.Location = new System.Drawing.Point(205, 155);
            this.btn_createAlbum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_createAlbum.Name = "btn_createAlbum";
            this.btn_createAlbum.Size = new System.Drawing.Size(87, 31);
            this.btn_createAlbum.TabIndex = 0;
            this.btn_createAlbum.Text = "Create";
            this.btn_createAlbum.UseVisualStyleBackColor = true;
            this.btn_createAlbum.Click += new System.EventHandler(this.btn_createAlbum_Click);
            // 
            // tabpage_songs
            // 
            this.tabpage_songs.Controls.Add(this.lbl_songMessage);
            this.tabpage_songs.Controls.Add(this.label5);
            this.tabpage_songs.Controls.Add(this.comboBox_albums);
            this.tabpage_songs.Controls.Add(this.txt_songLength);
            this.tabpage_songs.Controls.Add(this.label3);
            this.tabpage_songs.Controls.Add(this.txt_songTitle);
            this.tabpage_songs.Controls.Add(this.label4);
            this.tabpage_songs.Controls.Add(this.btn_createSong);
            this.tabpage_songs.Location = new System.Drawing.Point(4, 29);
            this.tabpage_songs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpage_songs.Name = "tabpage_songs";
            this.tabpage_songs.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpage_songs.Size = new System.Drawing.Size(413, 283);
            this.tabpage_songs.TabIndex = 1;
            this.tabpage_songs.Text = "Manage Songs";
            this.tabpage_songs.UseVisualStyleBackColor = true;
            // 
            // lbl_songMessage
            // 
            this.lbl_songMessage.AutoSize = true;
            this.lbl_songMessage.Location = new System.Drawing.Point(29, 221);
            this.lbl_songMessage.Name = "lbl_songMessage";
            this.lbl_songMessage.Size = new System.Drawing.Size(203, 20);
            this.lbl_songMessage.TabIndex = 12;
            this.lbl_songMessage.Text = "Fill the form to create a song.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Album : ";
            // 
            // comboBox_albums
            // 
            this.comboBox_albums.FormattingEnabled = true;
            this.comboBox_albums.Location = new System.Drawing.Point(144, 129);
            this.comboBox_albums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_albums.Name = "comboBox_albums";
            this.comboBox_albums.Size = new System.Drawing.Size(158, 28);
            this.comboBox_albums.TabIndex = 10;
            // 
            // txt_songLength
            // 
            this.txt_songLength.Location = new System.Drawing.Point(144, 81);
            this.txt_songLength.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_songLength.Name = "txt_songLength";
            this.txt_songLength.Size = new System.Drawing.Size(158, 27);
            this.txt_songLength.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Length in Secs. :";
            // 
            // txt_songTitle
            // 
            this.txt_songTitle.Location = new System.Drawing.Point(144, 32);
            this.txt_songTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_songTitle.Name = "txt_songTitle";
            this.txt_songTitle.Size = new System.Drawing.Size(158, 27);
            this.txt_songTitle.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Song Title : ";
            // 
            // btn_createSong
            // 
            this.btn_createSong.Location = new System.Drawing.Point(217, 176);
            this.btn_createSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_createSong.Name = "btn_createSong";
            this.btn_createSong.Size = new System.Drawing.Size(86, 31);
            this.btn_createSong.TabIndex = 5;
            this.btn_createSong.Text = "Create";
            this.btn_createSong.UseVisualStyleBackColor = true;
            this.btn_createSong.Click += new System.EventHandler(this.btn_createSong_Click);
            // 
            // tabpage_albumsSongs
            // 
            this.tabpage_albumsSongs.Controls.Add(this.txt_deleteSong);
            this.tabpage_albumsSongs.Controls.Add(this.btn_showSongs);
            this.tabpage_albumsSongs.Controls.Add(this.lst_songs);
            this.tabpage_albumsSongs.Controls.Add(this.lst_albums);
            this.tabpage_albumsSongs.Location = new System.Drawing.Point(4, 29);
            this.tabpage_albumsSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabpage_albumsSongs.Name = "tabpage_albumsSongs";
            this.tabpage_albumsSongs.Size = new System.Drawing.Size(413, 283);
            this.tabpage_albumsSongs.TabIndex = 2;
            this.tabpage_albumsSongs.Text = "Albums and Songs";
            this.tabpage_albumsSongs.UseVisualStyleBackColor = true;
            // 
            // txt_deleteSong
            // 
            this.txt_deleteSong.Location = new System.Drawing.Point(208, 229);
            this.txt_deleteSong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_deleteSong.Name = "txt_deleteSong";
            this.txt_deleteSong.Size = new System.Drawing.Size(154, 31);
            this.txt_deleteSong.TabIndex = 7;
            this.txt_deleteSong.Text = "Delete";
            this.txt_deleteSong.UseVisualStyleBackColor = true;
            this.txt_deleteSong.Click += new System.EventHandler(this.txt_deleteSong_Click);
            // 
            // btn_showSongs
            // 
            this.btn_showSongs.Location = new System.Drawing.Point(29, 189);
            this.btn_showSongs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_showSongs.Name = "btn_showSongs";
            this.btn_showSongs.Size = new System.Drawing.Size(159, 31);
            this.btn_showSongs.TabIndex = 4;
            this.btn_showSongs.Text = "Show Songs >";
            this.btn_showSongs.UseVisualStyleBackColor = true;
            this.btn_showSongs.Click += new System.EventHandler(this.btn_showSongs_Click);
            // 
            // lst_songs
            // 
            this.lst_songs.FormattingEnabled = true;
            this.lst_songs.ItemHeight = 20;
            this.lst_songs.Location = new System.Drawing.Point(208, 36);
            this.lst_songs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_songs.Name = "lst_songs";
            this.lst_songs.Size = new System.Drawing.Size(154, 184);
            this.lst_songs.TabIndex = 1;
            // 
            // lst_albums
            // 
            this.lst_albums.FormattingEnabled = true;
            this.lst_albums.ItemHeight = 20;
            this.lst_albums.Location = new System.Drawing.Point(29, 36);
            this.lst_albums.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lst_albums.Name = "lst_albums";
            this.lst_albums.Size = new System.Drawing.Size(158, 144);
            this.lst_albums.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 396);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabpage_album.ResumeLayout(false);
            this.tabpage_album.PerformLayout();
            this.tabpage_songs.ResumeLayout(false);
            this.tabpage_songs.PerformLayout();
            this.tabpage_albumsSongs.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabpage_album;
        private System.Windows.Forms.TabPage tabpage_songs;
        private System.Windows.Forms.TextBox txt_albumName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_createAlbum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_songLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_songTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_createSong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_albums;
        private System.Windows.Forms.TabPage tabpage_albumsSongs;
        private System.Windows.Forms.ListBox lst_songs;
        private System.Windows.Forms.ListBox lst_albums;
        private System.Windows.Forms.Label lbl_albumMessage;
        private System.Windows.Forms.Label lbl_songMessage;
        private System.Windows.Forms.DateTimePicker dtp_yearReleased;
        private System.Windows.Forms.Button btn_showSongs;
        private System.Windows.Forms.Button txt_deleteSong;
    }
}

