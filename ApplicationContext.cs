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

            //modelBuilder.Entity<Entity.Test>().HasKey(p => p.id);
            //эта почта будет уникальной

            modelBuilder.Entity<Type_question>().HasData(
                new Type_question
                {
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
                });

            modelBuilder.Entity<Question>().HasData(
               new Question
               {
                   id = 1,
                   name = "С кем поцеловался Наруто?",
                   Type_questionid = 1,
                   Testid = 2,
               },
               new Question
               {
                   id = 2,
                   name = "Сколько персонажей в геншине?",
                   Type_questionid = 1,
                   Testid = 4,
               },
               new Question
               {
                   id = 3,
                   name = "Вы любите решать дифференциальные уравнения?",
                   Type_questionid = 3,
                   Testid = 1,
               },
               new Question
               {
                   id = 4,
                   name = "Что пишется через дефис?",
                   Type_questionid = 2,
                   Testid = 2,
               });

            modelBuilder.Entity<Answer>().HasData(
               new Answer
               {
                   id = 1,
                   name = "Саске",
                   Questionid = 1,
               },
               new Answer
               {
                   id = 2,
                   name = "Какаси",
                   Questionid = 1,
               },
               new Answer
               {
                   id = 3,
                   name = "Оротимару",
                   Questionid = 1,
               },
               new Answer
               {
                   id = 4,
                   name = "Сакура",
                   Questionid = 1,
               },
               new Answer
               {
                   id = 5,
                   name = "56",
                   Questionid = 2,
               },
               new Answer
               {
                   id = 6,
                   name = "40",
                   Questionid = 2,
               },
               new Answer
               {
                   id = 7,
                   name = "61",
                   Questionid = 2,
               },
               new Answer
               {
                   id = 8,
                   name = "52",
                   Questionid = 2,
               },
               new Answer
               {
                   id = 9,
                   name = "Да",
                   Questionid = 3,
               },
               new Answer
               {
                   id = 10,
                   name = "Конечно",
                   Questionid = 3,
               },
               new Answer
               {
                   id = 11,
                   name = "Ещё как",
                   Questionid = 3,
               },
               new Answer
               {
                   id = 12,
                   name = "Либо",
                   Questionid = 4,
               },
               new Answer
               {
                   id = 13,
                   name = "То",
                   Questionid = 4,
               },
               new Answer
               {
                   id = 14,
                   name = "Зачем",
                   Questionid = 4,
               },
               new Answer
               {
                   id = 15,
                   name = "Потому",
                   Questionid = 4,
               });

            modelBuilder.Entity<Test>().HasData(
               new Test
               {
                   id = 1,
                   result = "Математика",
               },
               new Test
               {
                   id = 2,
                   result = "Русский язык",
               },
               new Test
               {
                   id = 3,
                   result = "Наруто",
               },
               new Test
               {
                   id = 4,
                   result = "Геншин",
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
