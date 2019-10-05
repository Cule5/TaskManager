using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Project;
using Core.Domain.Report;
using Core.Domain.Task;
using Core.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Report> Reports { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
