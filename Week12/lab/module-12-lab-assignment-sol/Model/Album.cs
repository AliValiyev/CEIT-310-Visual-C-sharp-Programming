using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M12_inclass_template.Model
{
    //[Table("AlbumRecords")] To rename database table name
    public class Album
    {
        //[Key] // To override default behaviour while determining primary key
        public int AlbumId { get; set; } // Primary Key
        // By default AlbumId or Id is treated as Primary Key <ClassName>Id
        
        [MinLength(3), MaxLength(150)]
        public string AlbumName { get; set; }
        
        [Column("ReleasedDate")]
        public DateTime Released { get; set; }

        [Range(1, 100)]
        public int Length { get; set; }
        public List<Song> Songs { get; set; } // Many songs
    }
}
