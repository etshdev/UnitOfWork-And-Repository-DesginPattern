using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Test.Tables;

namespace Test.DataAccessLayer
{
    public class TestRepoDB:DbContext
    {
        public TestRepoDB(DbContextOptions<TestRepoDB> option) : base(option)
        {
                
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Student> students { get; set; }
        public DbSet<School> schools { get; set; }


    }
}
