using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace M7IndividualActivitiy.Model
{
    public class StudentDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; } //a proxy to the Books table in the database
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=StudentManagement_v1");
        }

    }
}
