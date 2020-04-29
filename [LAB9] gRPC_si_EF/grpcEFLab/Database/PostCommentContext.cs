using Database.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{

  
        public class PostCommentContext : DbContext
        {
            public DbSet<Post> Posts { get; set; }
            public DbSet<Comment> Comments { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-RVIDM7O\SQLEXPRESS;Initial Catalog=grpcwithef;Integrated Security=True");
            }
        }
    
}
