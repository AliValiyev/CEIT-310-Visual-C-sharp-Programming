using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace in_class11.Model
{
    class DbStudent : DbContext

    {public DbSet <Student> Students { get; set; }
        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (Localdb)\mssqllocaldb;Database = StudetManagement");
        }
    }
}
