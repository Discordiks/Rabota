using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Rabota.Entity;
using System.Threading; //использование потоков

namespace Rabota
{
    public partial class Students_acc : Form
    {
        ApplicationContext db = new ApplicationContext();
        //Test_window f4;
        Thread th;
        public Students_acc()
        {
            InitializeComponent();
        }
        private void open(object obj)
        {
            Application.Run(new Test_window());
        }
        private void open1(object obj)
        {
            Application.Run(new Log_in());
        }
        private void matem_Click(object sender, EventArgs e)
        {
           
            List<Question> questions = db.Questions.Where(q => q.Testid == 1).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test(){ UserId =  User_info.user_id}; // создание 
           //надо проверить есть ли тест уже или нет
            db.Start_Tests.Add(start_Test);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            User_info.active_test_id = start_Test.id; //знание айди теста, который проходит пользователь
            MessageBox.Show("Открытие теста по математике");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }
        

        private void rus_z_Click(object sender, EventArgs e)
        {
            List<Question> questions = db.Questions.Where(q => q.Testid == 2).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test() { UserId = User_info.user_id };
            //надо проверить есть ли тест уже или нет
            db.Start_Tests.Add(start_Test);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            MessageBox.Show("Открытие теста по русскому");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }

        private void liter_Click(object sender, EventArgs e)
        {
            List<Question> questions = db.Questions.Where(q => q.Testid == 3).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test() { UserId = User_info.user_id };
            //надо проверить есть ли тест уже или нет
            db.Start_Tests.Add(start_Test);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            MessageBox.Show("Открытие теста по литературе");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }

        private void genshin_Click(object sender, EventArgs e)
        {
            List<Question> questions = db.Questions.Where(q => q.Testid == 4).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test() { UserId = User_info.user_id };
            //надо проверить есть ли тест уже или нет
            db.Start_Tests.Add(start_Test);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            MessageBox.Show("Открытие ГЕНШИНАААА");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult resulttt = MessageBox.Show("Уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (resulttt == DialogResult.Yes)
            {
                
                this.Close();
                th = new Thread(open1);
                th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
                th.Start();

            }
                
            this.TopMost = true; //открытие формы "самой верхней формой"


        }

        private void Students_acc_Load(object sender, EventArgs e)
        {
            fio.Text = User_info.user_ima;
        }
    }
}
