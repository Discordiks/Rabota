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
            try
            {  
                List<Question> questions = db.Questions.Where(q => q.Testid == 1).ToList();
                Random ran = new Random();
                questions = questions.OrderBy(_ => ran.Next()).ToList();
                Start_test start_Test = new Start_test() { UserId = User_info.user_id, resultat = 0 }; // создание
                db.Start_Tests.Add(start_Test);
                questions.RemoveAt(1);
                questions.RemoveAt(2);
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
            catch
            {
                MessageBox.Show("Загрузка теста");
            }
        }
        

        private void rus_z_Click(object sender, EventArgs e)
        {
            try 
            {
            List<Question> questions = db.Questions.Where(q => q.Testid == 2).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test() { UserId = User_info.user_id, resultat = 0 }; // создание
            db.Start_Tests.Add(start_Test);
            questions.RemoveAt(1);
            questions.RemoveAt(2);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            User_info.active_test_id = start_Test.id; //знание айди теста, который проходит пользователь
            MessageBox.Show("Открытие теста по русскому языку");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
            }
            catch
            {
                MessageBox.Show("Загрузка теста");
            }
        }

        private void liter_Click(object sender, EventArgs e)
        {
            try
            { 
            List<Question> questions = db.Questions.Where(q => q.Testid == 3).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test() { UserId = User_info.user_id, resultat = 0 }; // создание
            db.Start_Tests.Add(start_Test);
            questions.RemoveAt(1);
            questions.RemoveAt(2);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            User_info.active_test_id = start_Test.id; //знание айди теста, который проходит пользователь
            MessageBox.Show("Открытие теста по Наруто");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
            }
            catch
            {
                MessageBox.Show("Загрузка теста");
            }
        }

        private void genshin_Click(object sender, EventArgs e)
        {
            try
            { 
            List<Question> questions = db.Questions.Where(q => q.Testid == 4).ToList();
            Random ran = new Random();
            questions = questions.OrderBy(_ => ran.Next()).ToList();
            Start_test start_Test = new Start_test() { UserId = User_info.user_id, resultat = 0 }; // создание
            db.Start_Tests.Add(start_Test);
            questions.RemoveAt(1);
            questions.RemoveAt(2);
            for (int i = 0; i < questions.Count; i++)
            {
                Start_test_q start_Test_Q = new Start_test_q() { start_Test = start_Test, user_answer = 0, question = questions[i] };
                db.Start_Tests_q.Add(start_Test_Q);
            }
            db.SaveChanges();
            User_info.active_test_id = start_Test.id; //знание айди теста, который проходит пользователь
            MessageBox.Show("Открытие теста по Геншину");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
            }
            catch
            {
                MessageBox.Show("Загрузка теста");
            }
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
            fio.Text = "Добро\nпожаловать,\n" + User_info.user_ima;
        }

        private void procent_Click(object sender, EventArgs e)
        {
            int a, b, c, d ;
            List<Start_test> start_Tests = db.Start_Tests.Include(st => st.Start_test_qs)
                .ThenInclude(stq => stq.question).Where(st => st.UserId == User_info.user_id)
                .OrderByDescending(o => o.id).ToList();
            a = CheckTest(1, start_Tests);
            b = CheckTest(2, start_Tests);
            c = CheckTest(3, start_Tests);
            d = CheckTest(4, start_Tests);
            MessageBox.Show("Математика: "+ a + " баллов из 8" +"\nРусский: " + b + " баллов из 8" + "\nНаруто: " + c + " баллов из 8" + "\nГеншин: " + d + " баллов из 8");
        }
        private int CheckTest(int testId, List<Start_test> start_Tests)
        {
            Start_test ad = start_Tests.Find(st => st.Start_test_qs[0].question.Testid == testId);
            if (ad == null)
            {
                return 0;
            }
            return ad.resultat;
        }
    }
}
