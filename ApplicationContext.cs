using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rabota.Entity;
using System.Windows.Forms;



namespace Rabota
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; } //последование классов

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=App.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(p => p.id);
            modelBuilder.Entity<User>().HasIndex(p => p.email).IsUnique(); //эта почта будет уникальной
            base.OnModelCreating(modelBuilder); //проверка почты на копии

        }
        public ApplicationContext() //просмотр классов
        {
            this.Database.EnsureCreated();
        }
            
    }
}
