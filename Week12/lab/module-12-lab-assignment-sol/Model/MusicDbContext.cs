using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M12_inclass_template.Model
{
    public class MusicDbContext : DbContext
    {
        public MusicDbContext() : base("MusicManagementDb") 
        {

        }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; } 

    }
}
