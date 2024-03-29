﻿using System;
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
        public DbSet<Start_test_q> Start_Tests_q { get; set; }
        public DbSet<Start_test> Start_Tests { get; set; }


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


            modelBuilder.Entity<Test>().HasData(
              new Test
              {
                  id = 1,
                  name = "Математика",
              },
              new Test
              {
                  id = 2,
                  name = "Русский язык",
              },
              new Test
              {
                  id = 3,
                  name = "Наруто",
              },
              new Test
              {
                  id = 4,
                  name = "Геншин",
              });
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
                //Наруто
               new Question
               {
                   id = 1,
                   name = "С кем поцеловался Наруто?",
                   Type_questionid = 1,
                   Testid = 3,
               },
               new Question
               {
                   id = 2,
                   name = "К какому клану принадлежит Обито?",
                   Type_questionid = 1,
                   Testid = 3,
               },
               new Question
               {
                   id = 3,
                   name = "Кого Итачи победил в подземелье?",
                   Type_questionid = 1,
                   Testid = 3,
               },
               new Question
               {
                   id = 4,
                   name = "Кому принадлежат слова\n\"Я буду любить тебя всегда\"?",
                   Type_questionid = 1,
                   Testid = 3,
               },
               new Question
               {
                   id = 5,
                   name = "Назовите великую технику,\nкоторую смог реализовать \nМадара с помощью Обито",
                   Type_questionid = 2,
                   Testid = 3,
               },
               new Question
               {
                   id = 6,
                   name = "Кто очень сильно ждал Хашираму?",
                   Type_questionid = 1,
                   Testid = 3,
               },
               new Question
               {
                   id = 7,
                   name = "Великая фраза Наруто?",
                   Type_questionid = 2,
                   Testid = 3,
               },
               new Question
               {
                   id = 8,
                   name = "Кто умер в названии серии?",
                   Type_questionid = 3,
                   Testid = 3,
               },
               new Question
               {
                   id = 9,
                   name = "Как называется знаменитая\nтехника Какаши?",
                   Type_questionid = 3,
                   Testid = 3,
               },
               new Question
               {
                   id = 10,
                   name = "Сколько учеников в каждой команде?",
                   Type_questionid = 1,
                   Testid = 3,
               },
               //Геншин
               new Question
               {
                   id = 11,
                   name = "Сколько персонажей в геншине?",
                   Type_questionid = 1,
                   Testid = 4,
               },
               new Question
               {
                   id = 12,
                   name = "Сколько игровых архонтов существует\nна данный момент?",
                   Type_questionid = 1,
                   Testid = 4,
               },
               new Question
               {
                   id = 13,
                   name = "Какой элемент у Странника?",
                   Type_questionid = 3,
                   Testid = 4,
               },
               new Question
               {
                   id = 14,
                   name = "Кто дружит с мегакрутым быком?",
                   Type_questionid = 1,
                   Testid = 4,
               },
               new Question
               {
                   id = 15,
                   name = "Кто является дендро персонажем?",
                   Type_questionid = 2,
                   Testid = 4,
               },
               new Question
               {
                   id = 16,
                   name = "Сколько молитв (как максимум)\nнеобходимо для леги?",
                   Type_questionid = 1,
                   Testid = 4,
               },
               new Question
               {
                   id = 17,
                   name = "В какой стране \"родился\" Геншин?",
                   Type_questionid = 3,
                   Testid = 4,
               },
               new Question
               {
                   id = 18,
                   name = "Кто является 11-ым\nПредвестником Фатуи?",
                   Type_questionid = 2,
                   Testid = 4,
               },
               new Question
               {
                   id = 19,
                   name = "Какой элемент, как игровой,\nпоявился позже всех?",
                   Type_questionid = 1,
                   Testid = 4,
               },
               new Question
               {
                   id = 20,
                   name = "Хотите задонатить????",
                   Type_questionid = 2,
                   Testid = 4,
               },

               //Математика
               new Question
               {
                   id = 21,
                   name = "Вы любите решать\nдифференциальные уравнения?",
                   Type_questionid = 3,
                   Testid = 1,
               },
               new Question
               {
                   id = 22,
                   name = "Площадь прямоугольника\nсо сторонами 15 и 5 см?",
                   Type_questionid = 1,
                   Testid = 1,
               },
               new Question
               {
                   id = 23,
                   name = "Среднее арифметическое чисел\n16, 27, 98?",
                   Type_questionid = 1,
                   Testid = 1,
               },
               new Question
               {
                   id = 24,
                   name = "Самое маленькое число, в записи\nкоторого все цифры различны?",
                   Type_questionid = 3,
                   Testid = 1,
               },
               new Question
               {
                   id = 25,
                   name = "Точка, равноудаленная от всех точек\nокружности?",
                   Type_questionid = 3,
                   Testid = 1,
               },
               new Question
               {
                   id = 26,
                   name = "Равенство, устанавливающее связь между\nнезависимой искомой величиной и\nизвестными величинами?",
                   Type_questionid = 1,
                   Testid = 1,
               },
               new Question
               {
                   id = 27,
                   name = "Рациональные числа - это",
                   Type_questionid = 2,
                   Testid = 1,
               },
               new Question
               {
                   id = 28,
                   name = "На экзамене было 120 вопросов, Катя\nне выучила 6 из них.\nНайдите вероятность того, что ей\nпопадётся выученный вопрос",
                   Type_questionid = 1,
                   Testid = 1,
               },
               new Question
               {
                   id = 29,
                   name = "С помощью чего можно решить\nквадратное уравнение?",
                   Type_questionid = 2,
                   Testid = 1,
               },
               new Question
               {
                   id = 30,
                   name = "Сколько трёхзначных слов можно\nсоставить из слова \"Арбуз\",\nгде словом считается\nлюбое сочетание букв",
                   Type_questionid = 3,
                   Testid = 1,
               },
               //Русский язык
               new Question
               {
                   id = 31,
                   name = "Что пишется через дефис?",
                   Type_questionid = 2,
                   Testid = 2,
               },
               new Question
               {
                   id = 32,
                   name = "Мат существует?",
                   Type_questionid = 1,
                   Testid = 2,
               },
               new Question
               {
                   id = 33,
                   name = "Сколько букв в русском алфавите?",
                   Type_questionid = 1,
                   Testid = 2,
               },
               new Question
               {
                   id = 34,
                   name = "Укажите слово, в котором ударение\nстоит верно",
                   Type_questionid = 1,
                   Testid = 2,
               },
               new Question
               {
                   id = 35,
                   name = "Как называется популярная олимпиада\nпо русскому языку?",
                   Type_questionid = 3,
                   Testid = 2,
               },
               new Question
               {
                   id = 36,
                   name = "Что из перечисленного не обосабливается\nс двух сторон?",
                   Type_questionid = 2,
                   Testid = 2,
               },
               new Question
               {
                   id = 37,
                   name = "Вставьте пропущенное слово:\n\"Я пошёл гулять, но ... и упал\"",
                   Type_questionid = 1,
                   Testid = 2,
               },
               new Question
               {
                   id = 38,
                   name = "Как называется цвет, сочетающий в себе\nсерый и зелёный?",
                   Type_questionid = 3,
                   Testid = 2,
               },
               new Question
               {
                   id = 39,
                   name = "Надо ли знать русский,\nчтобы играть в геншин?",
                   Type_questionid = 3,
                   Testid = 2,
               },
               new Question
               {
                   id = 40,
                   name = "Какого оборота не существует?",
                   Type_questionid = 2,
                   Testid = 2,
               }
               );

            modelBuilder.Entity<Answer>().HasData(
               //1
               new Answer
               {
                   id = 1,
                   name = "Саске",
                   Questionid = 1,
                   vernost = 1,

               },
               new Answer
               {
                   id = 2,
                   name = "Какаси",
                   Questionid = 1,
                   vernost = 0,
               },
               new Answer
               {
                   id = 3,
                   name = "Оротимару",
                   Questionid = 1,
                   vernost = 0,
               },
               //2
               new Answer
               {
                   id = 4,
                   name = "Учиха",
                   Questionid = 2,
                   vernost = 1,
               },
               new Answer
               {
                   id = 5,
                   name = "Удзумаки",
                   Questionid = 2,
                   vernost = 0,
               },
               new Answer
               {
                   id = 6,
                   name = "Шукаку",
                   Questionid = 2,
                   vernost = 0,
               },
               //3
               new Answer
               {
                   id = 7,
                   name = "Саске Учиха",
                   Questionid = 3,
                   vernost = 0,
               },
               new Answer
               {
                   id = 8,
                   name = "Яшуно Кабуто",
                   Questionid = 3,
                   vernost = 1,
               },
               new Answer
               {
                   id = 9,
                   name = "Оротимару",
                   Questionid = 3,
                   vernost = 0,
               },
               //4
               new Answer
               {
                   id = 10,
                   name = "Мадара",
                   Questionid = 4,
                   vernost = 0,
               },
               new Answer
               {
                   id = 11,
                   name = "Хаширама",
                   Questionid = 4,
                   vernost = 0,
               },
               new Answer
               {
                   id = 12,
                   name = "Учиха Итачи",
                   Questionid = 4,
                   vernost = 1,
               },
               //5
               new Answer
               {
                   id = 13,
                   name = "Шаринган",
                   Questionid = 5,
                   vernost = 0,
               },
               new Answer
               {
                   id = 14,
                   name = "Вечное Цукуёми",
                   Questionid = 5,
                   vernost = 1,
               },
               new Answer
               {
                   id = 15,
                   name = "Сусано",
                   Questionid = 5,
                   vernost = 0,
               },
               //6
               new Answer
               {
                   id = 16,
                   name = "Сакура",
                   Questionid = 6,
                   vernost = 0,
               },
               new Answer
               {
                   id = 17,
                   name = "Мадара",
                   Questionid = 6,
                   vernost = 1,
               },
               new Answer
               {
                   id = 18,
                   name = "Наруто",
                   Questionid = 6,
                   vernost = 0,
               },
               //7
               new Answer
               {
                   id = 19,
                   name = "Я стану Хокаге!",
                   Questionid = 7,
                   vernost = 1,
               },
               new Answer
               {
                   id = 20,
                   name = "Я обязательно сдам экзамен!",
                   Questionid = 7,
                   vernost = 0,
               },
               new Answer
               {
                   id = 21,
                   name = "Ничего непонятно, но\nумный вид сделать надо!",
                   Questionid = 7,
                   vernost = 0,
               },
               //8
               new Answer
               {
                   id = 22,
                   name = "Гаара",
                   Questionid = 8,
                   vernost = 1,
               },
               new Answer
               {
                   id = 23,
                   name = "Джирайя",
                   Questionid = 8,
                   vernost = 0,
               },
               new Answer
               {
                   id = 24,
                   name = "Пейн",
                   Questionid = 8,
                   vernost = 0,
               },
               //9
               new Answer
               {
                   id = 25,
                   name = "32 мягких удара",
                   Questionid = 9,
                   vernost = 0,
               },
               new Answer
               {
                   id = 26,
                   name = "Чидори",
                   Questionid = 9,
                   vernost = 1,
               },
               new Answer
               {
                   id = 27,
                   name = "Раасенган",
                   Questionid = 9,
                   vernost = 0,
               },
               //10
               new Answer
               {
                   id = 28,
                   name = "3",
                   Questionid = 10,
                   vernost = 1,
               },
               new Answer
               {
                   id = 29,
                   name = "8",
                   Questionid = 10,
                   vernost = 0,
               },
               new Answer
               {
                   id = 30,
                   name = "5",
                   Questionid = 10,
                   vernost = 0,
               },
               //11
               new Answer
               {
                   id = 31,
                   name = "54",
                   Questionid = 11,
                   vernost = 1,
               },
               new Answer
               {
                   id = 32,
                   name = "60",
                   Questionid = 11,
                   vernost = 0,
               },
               new Answer
               {
                   id = 33,
                   name = "48",
                   Questionid = 11,
                   vernost = 0,
               },
               //12
               new Answer
               {
                   id = 34,
                   name = "2",
                   Questionid = 12,
                   vernost = 0,
               },
               new Answer
               {
                   id = 35,
                   name = "3",
                   Questionid = 12,
                   vernost = 0,
               },
               new Answer
               {
                   id = 36,
                   name = "4",
                   Questionid = 12,
                   vernost = 1,
               },
               //13
               new Answer
               {
                   id = 37,
                   name = "Электро",
                   Questionid = 13,
                   vernost = 0,
               },
               new Answer
               {
                   id = 38,
                   name = "Анемо",
                   Questionid = 13,
                   vernost = 1,
               },
               new Answer
               {
                   id = 39,
                   name = "Гео",
                   Questionid = 13,
                   vernost = 0,
               },
               //14
               new Answer
               {
                   id = 40,
                   name = "Райден",
                   Questionid = 14,
                   vernost = 0,
               },
               new Answer
               {
                   id = 41,
                   name = "Сяо",
                   Questionid = 14,
                   vernost = 0,
               },
               new Answer
               {
                   id = 42,
                   name = "Итто",
                   Questionid = 14,
                   vernost = 1,
               },
               //15
               new Answer
               {
                   id = 43,
                   name = "Тигнари",
                   Questionid = 15,
                   vernost = 1,
               },
               new Answer
               {
                   id = 44,
                   name = "Дэхья",
                   Questionid = 15,
                   vernost = 0,
               },
               new Answer
               {
                   id = 45,
                   name = "Сайно",
                   Questionid = 15,
                   vernost = 0,
               },
               //16
               new Answer
               {
                   id = 46,
                   name = "80",
                   Questionid = 16,
                   vernost = 0,
               },
               new Answer
               {
                   id = 47,
                   name = "90",
                   Questionid = 16,
                   vernost = 1,
               },
               new Answer
               {
                   id = 48,
                   name = "70",
                   Questionid = 16,
                   vernost = 0,

               },
               //17
               new Answer
               {
                   id = 49,
                   name = "Китай",
                   Questionid = 17,
                   vernost = 1,
               },
               new Answer
               {
                   id = 50,
                   name = "Япония",
                   Questionid = 17,
                   vernost = 0,
               },
               new Answer
               {
                   id = 51,
                   name = "Корея",
                   Questionid = 17,
                   vernost = 0,
               },
               //18
               new Answer
               {
                   id = 52,
                   name = "Дотторе",
                   Questionid = 18,
                   vernost = 0,
               },
               new Answer
               {
                   id = 53,
                   name = "Нахида",
                   Questionid = 18,
                   vernost = 0,
               },
               new Answer
               {
                   id = 54,
                   name = "Тарталья",
                   Questionid = 18,
                   vernost = 1,
               },
               //19
               new Answer
               {
                   id = 55,
                   name = "Пиро",
                   Questionid = 19,
                   vernost = 0,
               },
               new Answer
               {
                   id = 56,
                   name = "Гео",
                   Questionid = 19,
                   vernost = 0,
               },
               new Answer
               {
                   id = 57,
                   name = "Дендро",
                   Questionid = 19,
                   vernost = 1,
               },
               //20
               new Answer
               {
                   id = 58,
                   name = "Конечно (нет)",
                   Questionid = 20,
                   vernost = 1,
               },
               new Answer
               {
                   id = 59,
                   name = "Обязательно",
                   Questionid = 20,
                   vernost = 1,
               },
               new Answer
               {
                   id = 60,
                   name = "Уже",
                   Questionid = 20,
                   vernost = 1,
               },
               //21
               new Answer
               {
                   id = 61,
                   name = "Да",
                   Questionid = 21,
                   vernost = 1,
               },
               new Answer
               {
                   id = 62,
                   name = "Конечно",
                   Questionid = 21,
                   vernost = 1,
               },
               new Answer
               {
                   id = 63,
                   name = "Ещё как",
                   Questionid = 21,
                   vernost = 1,
               },
               //22
               new Answer
               {
                   id = 64,
                   name = "75",
                   Questionid = 22,
                   vernost = 1,
               },
               new Answer
               {
                   id = 65,
                   name = "20",
                   Questionid = 22,
                   vernost = 0,
               },
               new Answer
               {
                   id = 66,
                   name = "3",
                   Questionid = 22,
                   vernost = 0,
               },
               //23
               new Answer
               {
                   id = 67,
                   name = "47",
                   Questionid = 23,
                   vernost = 1,
               },
               new Answer
               {
                   id = 68,
                   name = "33",
                   Questionid = 23,
                   vernost = 0,
               },
               new Answer
               {
                   id = 69,
                   name = "27",
                   Questionid = 23,
                   vernost = 0,
               },
               //24
               new Answer
               {
                   id = 70,
                   name = "1023",
                   Questionid = 24,
                   vernost = 1,
               },
               new Answer
               {
                   id = 71,
                   name = "0123",
                   Questionid = 24,
                   vernost = 0,
               },
               new Answer
               {
                   id = 72,
                   name = "1234",
                   Questionid = 24,
                   vernost = 0,
               },
               //25
               new Answer
               {
                   id = 73,
                   name = "Цель",
                   Questionid = 25,
                   vernost = 0,
               },
               new Answer
               {
                   id = 74,
                   name = "Точка",
                   Questionid = 25,
                   vernost = 0,
               },
               new Answer
               {
                   id = 75,
                   name = "Центр",
                   Questionid = 25,
                   vernost = 1,
               },
               //26
               new Answer
               {
                   id = 76,
                   name = "Равенство выражений",
                   Questionid = 26,
                   vernost = 0,
               },
               new Answer
               {
                   id = 77,
                   name = "Уравнение",
                   Questionid = 26,
                   vernost = 1,
               },
               new Answer
               {
                   id = 78,
                   name = "Система",
                   Questionid = 26,
                   vernost = 0,
               },
               //27
               new Answer
               {
                   id = 79,
                   name = "Числа, которое можно представить\n в виде обыкновенной дроби",
                   Questionid = 27,
                   vernost = 1,
               },
               new Answer
               {
                   id = 80,
                   name = "Целые числа",
                   Questionid = 27,
                   vernost = 0,
               },
               new Answer
               {
                   id = 81,
                   name = "Числа, которые\nделятся на 2",
                   Questionid = 27,
                   vernost = 0,
               },
               //28
               new Answer
               {
                   id = 82,
                   name = "0,95",
                   Questionid = 28,
                   vernost = 1,
               },
               new Answer
               {
                   id = 83,
                   name = "0,05",
                   Questionid = 28,
                   vernost = 0,
               },
               new Answer
               {
                   id = 84,
                   name = "0,053",
                   Questionid = 28,
                   vernost = 0,
               },
               //29
               new Answer
               {
                   id = 85,
                   name = "Теорема Коши",
                   Questionid = 29,
                   vernost = 0,
               },
               new Answer
               {
                   id = 86,
                   name = "Теорема Виетта",
                   Questionid = 29,
                   vernost = 1,
               },
               new Answer
               {
                   id = 87,
                   name = "Теорема Пифагора",
                   Questionid = 29,
                   vernost = 0,
               },
               //30
               new Answer
               {
                   id = 88,
                   name = "25",
                   Questionid = 30,
                   vernost = 0,
               },
               new Answer
               {
                   id = 89,
                   name = "120",
                   Questionid = 30,
                   vernost = 0,
               },
               new Answer
               {
                   id = 90,
                   name = "60",
                   Questionid = 30,
                   vernost = 1,
               },
               //31
               new Answer
               {
                   id = 91,
                   name = "Да",
                   Questionid = 31,
                   vernost = 0,
               },
               new Answer
               {
                   id = 92,
                   name = "Же",
                   Questionid = 31,
                   vernost = 0,
               },
               new Answer
               {
                   id = 93,
                   name = "То",
                   Questionid = 31,
                   vernost = 1,
               },
               //32
               new Answer
               {
                   id = 94,
                   name = "Что это?",
                   Questionid = 32,
                   vernost = 0,
               },
               new Answer
               {
                   id = 95,
                   name = "Да",
                   Questionid = 32,
                   vernost = 1,
               },
               new Answer
               {
                   id = 96,
                   name = "Нет",
                   Questionid = 32,
                   vernost = 0,
               },
               //33
               new Answer
               {
                   id = 97,
                   name = "30",
                   Questionid = 33,
                   vernost = 0,
               },
               new Answer
               {
                   id = 98,
                   name = "28",
                   Questionid = 33,
                   vernost = 0,
               },
               new Answer
               {
                   id = 99,
                   name = "33",
                   Questionid = 33,
                   vernost = 1,
               },
               //34
               new Answer
               {
                   id = 100,
                   name = "жАлюзи",
                   Questionid = 34,
                   vernost = 0,
               },
               new Answer
               {
                   id = 101,
                   name = "кровоточАщий",
                   Questionid = 34,
                   vernost = 1,
               },
               new Answer
               {
                   id = 102,
                   name = "дЕньгами",
                   Questionid = 34,
                   vernost = 0,
               },
               //35
               new Answer
               {
                   id = 103,
                   name = "Русский медвежонок",
                   Questionid = 35,
                   vernost = 1,
               },
               new Answer
               {
                   id = 104,
                   name = "Русский соболь",
                   Questionid = 35,
                   vernost = 0,
               },
               new Answer
               {
                   id = 105,
                   name = "Русский кролик",
                   Questionid = 35,
                   vernost = 0,
               },
               //36
               new Answer
               {
                   id = 106,
                   name = "Деепричастный оборот",
                   Questionid = 36,
                   vernost = 0,
               },
               new Answer
               {
                   id = 107,
                   name = "Обобщающее слово",
                   Questionid = 36,
                   vernost = 1,
               },
               new Answer
               {
                   id = 108,
                   name = "Обращение",
                   Questionid = 36,
                   vernost = 0,
               },
               //37
               new Answer
               {
                   id = 109,
                   name = "Подскользнулся",
                   Questionid = 37,
                   vernost = 0,
               },
               new Answer
               {
                   id = 110,
                   name = "Поскользнулся",
                   Questionid = 37,
                   vernost = 1,
               },
               new Answer
               {
                   id = 111,
                   name = "Подскальзнулся",
                   Questionid = 37,
                   vernost = 0,
               },
               //38
               new Answer
               {
                   id = 112,
                   name = "Серо-зелёный",
                   Questionid = 38,
                   vernost = 1,
               },
               new Answer
               {
                   id = 113,
                   name = "Серо зелёный",
                   Questionid = 38,
                   vernost = 0,
               },
               new Answer
               {
                   id = 114,
                   name = "Серозелёный",
                   Questionid = 38,
                   vernost = 0,
               },
               //39
               new Answer
               {
                   id = 115,
                   name = "Да, иначе никак",
                   Questionid = 39,
                   vernost = 0,
               },
               new Answer
               {
                   id = 116,
                   name = "Необязательно",
                   Questionid = 39,
                   vernost = 0,
               },
               new Answer
               {
                   id = 117,
                   name = "Я русский!",
                   Questionid = 39,
                   vernost = 1,
               },
               //40
               new Answer
               {
                   id = 118,
                   name = "Деепричастного",
                   Questionid = 40,
                   vernost = 0,
               },
               new Answer
               {
                   id = 119,
                   name = "Причастного",
                   Questionid = 40,
                   vernost = 0,
               },
               new Answer
               {
                   id = 120,
                   name = "Частного",
                   Questionid = 40,
                   vernost = 1,
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
