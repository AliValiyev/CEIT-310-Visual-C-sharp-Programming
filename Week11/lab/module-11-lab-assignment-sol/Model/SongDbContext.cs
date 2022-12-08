using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m10-lab-ali.Model
{
    internal class SongDbContext : DbContext
    {
        public SongDbContext (): base("SongManagementDb") { }
        public DbSet<Song> Songs { get; set; }
    }
}
