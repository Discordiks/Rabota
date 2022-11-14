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
        //перечисление таблиц
        public DbSet<User> Users { get; set; } 
        public DbSet<Entity.Test> Tests { get; set; }
        public DbSet<Type_question> Type_Questions { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Answer> Answers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // конфигурация БД
            optionsBuilder.UseSqlite("Data Source=App.sqlite");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // конфигурация моделей
            modelBuilder.Entity<User>().HasKey(p => p.id);
            modelBuilder.Entity<User>().HasIndex(p => p.email).IsUnique();

            modelBuilder.Entity<Entity.Test>().HasKey(p => p.id);
            //эта почта будет уникальной

            modelBuilder.Entity<Type_question>().HasData(
                new Type_question { 
                    id = 1,
                    name = "Один вариант ответа"
                    },
                new Type_question
                {
                    id = 2,
                    name = "Несколько вариантов ответа"
                },
                new Type_question
                {
                    id = 3,
                    name = "Самостоятельный ответ"
                }
                );

            modelBuilder.Entity<Question>().HasData(
               new Question
               {
                   id = 1,
                   name = "Сколько весит ёж?",
                   Type_questionid = 1,
                   test_id = 2,
               });

           base.OnModelCreating(modelBuilder); //проверка почты на копии

        }
      
        public ApplicationContext() //просмотр классов
        {
            //this.Database.EnsureDeleted(); //удаление БД (использовать если изменили структуру)
            this.Database.EnsureCreated(); //Создание БД (создает если не находит файл бд, или он пустой)
        }
        
    }
}
