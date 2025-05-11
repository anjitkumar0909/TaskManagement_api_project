using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TaskManagement_api.Models
{
    public class TaskManagement_DBContext : DbContext 
    {
        public TaskManagement_DBContext()
        {
        }

        public TaskManagement_DBContext(DbContextOptions<TaskManagement_DBContext> options)
            : base(options)
        {
        }

        public DbSet<User> User { get; set; }
        public DbSet<task> Task { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<task>(entity =>
            {
                entity.ToTable("Task");

                entity.Property(e => e.TaskName).HasMaxLength(100);
            });

            modelBuilder.Entity<User>(entity =>
            {
               

                 entity.HasOne(e => e.Task)
        .WithMany(d => d.Users)
        .HasForeignKey(e => e.TaskId)
        .OnDelete(DeleteBehavior.SetNull);

            });

           // OnModelCreatingPartial(modelBuilder);
        }

       // partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
