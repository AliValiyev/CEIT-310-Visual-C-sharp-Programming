using M12_inclass_template.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module12_home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        MusicDbContext db = new MusicDbContext();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_createAlbum_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Album class
                Album album = new Album()
                {
                    AlbumName = txt_albumName.Text,
                    Released = dtp_yearReleased.Value,
                    Length = 10
                };
                
                //Add the album instance to the database
                db.Albums.Add(album);
                db.SaveChanges();
                //Show message and reset the fields
                lbl_albumMessage.Text = "Album is successfully created!";
                txt_albumName.Text = "";

            }
            catch (Exception ex)
            {
                lbl_albumMessage.Text = "An error has occured. More info: " + ex.Message;
            }
        }


        private void btn_createSong_Click(object sender, EventArgs e)
        {
            try
            {
                //Create an instance of Song class
                Song song = new Song()
                {
                    Title = txt_songTitle.Text,
                    Length = int.Parse(txt_songLength.Text),
                    AlbumId = (int) comboBox_albums.SelectedValue
                };


                //Add the song instance to the database
                db.Songs.Add(song);
                db.SaveChanges();


                //Show message and reset the fields
                lbl_songMessage.Text = "Song is created";
                txt_songTitle.Text = "";
                txt_songLength.Text = "";

            }
            catch (Exception ex)
            {
                lbl_songMessage.Text = "An error has occured. More info: " + ex.Message;
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControl1.SelectedTab == tabpage_albumsSongs)
            {
                lst_albums.DataSource = db.Albums.ToList();
                lst_albums.ValueMember = "AlbumId";
                lst_albums.DisplayMember = "AlbumName";

            }
            else if(tabControl1.SelectedTab == tabpage_songs)
            {
                comboBox_albums.ValueMember = "AlbumId";
                comboBox_albums.DisplayMember = "AlbumName";
                comboBox_albums.DataSource = db.Albums.ToList();
            }
        }

        private void btn_showSongs_Click(object sender, EventArgs e)
        {
            BringSongs();
        }

        private void BringSongs()
        {
            int selectedAlbumId = (int)lst_albums.SelectedValue;
            lst_songs.DataSource = db.Songs
                .Where(s => s.AlbumId == selectedAlbumId)
                .ToList();
            lst_songs.ValueMember = "SongId";
            lst_songs.DisplayMember = "Title";
        }

        private void txt_deleteSong_Click(object sender, EventArgs e)
        {
            int songId = (int) lst_songs.SelectedValue;
            Song songToDelete = db.Songs.Find(songId);
            db.Songs.Remove(songToDelete);
            db.SaveChanges();
            BringSongs();

        }
    }

}
