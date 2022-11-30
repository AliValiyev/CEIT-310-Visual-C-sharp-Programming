using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M12_inclass_template.Model
{
    public class Song
    {
        public int SongId { get; set; }
        public string Title { get; set; }
        public int Length { get; set; }
        

        public int AlbumId { get; set; } // I have to say that this is Foreign Key

        [ForeignKey("AlbumId")]
        public Album ParentAlbum { get; set; } // Only one album
    }
}
