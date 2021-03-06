﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Domain.Account;
using Core.Domain.Conversation;
using Core.Domain.Group;
using Core.Domain.GroupProject;
using Core.Domain.Project;
using Core.Domain.ProjectUser;
using Core.Domain.Report;
using Core.Domain.Task;
using Core.Domain.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.EntityFramework
{
    public class AppDbContext:DbContext
    {
        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Conversation> Conversations { get; set; }
        public virtual DbSet<GroupProject> GroupProjects { get; set; }
        public virtual DbSet<Group> Groups { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectUser> ProjectUsers { get; set; }
        public virtual DbSet<WorkItem> Reports { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(@"Server=localhost;Database=TaskManagerDataBase;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(a => a.AccountId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Conversation>()
                .Property(c=>c.ConversationId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Group>()
                .Property(g => g.GroupId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Project>()
                .Property(p => p.ProjectId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<WorkItem>()
                .Property(r => r.ReportId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<Task>()
                .Property(t => t.TaskId)
                .ValueGeneratedOnAdd();
            modelBuilder.Entity<User>()
                .Property(u => u.UserId)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Account>()
                .HasOne(a => a.User)
                .WithOne(u => u.Account)
                .HasForeignKey<User>(u => u.AccountId);
        }
    }
}
