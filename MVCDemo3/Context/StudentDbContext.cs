using Microsoft.EntityFrameworkCore;
using MVCDemo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo3.Context
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options)
            :base(options)
        { }
        
        public DbSet<Student> Students { get; set; }
        public DbSet<Movie> Movies { get; set; }
        //protected override void OnConfiguring()
        //{

        //}
    }
}
