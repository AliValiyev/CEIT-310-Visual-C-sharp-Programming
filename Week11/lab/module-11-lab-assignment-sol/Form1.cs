using m10-lab-ali.Model;
using System.Windows.Forms;

namespace m10-lab-ali
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool fully_uploaded_form = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            BindSongs();
        }

        private void btn_createSong_Click(object sender, EventArgs e)
        {
            Song song = new Song()
            {
                Title = txt_songTitle.Text,
                Album = txt_album.Text,
                Singer = txt_singer.Text
            };
            SongDbContext db = new SongDbContext();
            db.Songs.Add(song);
            db.SaveChanges();
            BindSongs();
        }

        public void BindSongs()
        {
            SongDbContext db = new SongDbContext();
            lst_songs.DataSource = db.Songs.ToList();
            lst_songs.ValueMember = "Id";
            lst_songs.DisplayMember = "Title";
            if (fully_uploaded_form == false)
            {
                fully_uploaded_form = true;
            }
        }

        private void lst_songs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (fully_uploaded_form)
            {
                SongDbContext db = new SongDbContext();
                int songId = (int)lst_songs.SelectedValue;
                Song song = db.Songs.Find(songId);
                lbl_title.Text = song.Title;
                lbl_ssinger.Text = song.Singer;
                lbl_salbum.Text = song.Album;
                
            }


        }
    }
}