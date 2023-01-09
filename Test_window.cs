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
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.Remoting.Channels;

namespace Rabota
{
    public partial class Test_window : Form
    {
        ApplicationContext db = new ApplicationContext();
        Thread th;
        int rez = 0;
        int tekuhiy_q;
        public List<Start_test_q> Start_test_qs { get; set; } = new List<Start_test_q>();
        public Test_window()
        {
            
            try
            {
                InitializeComponent();
                Start_test start_Test = db.Start_Tests.Include(q => q.Start_test_qs).ThenInclude(r => r.question).Where(p => p.id == User_info.active_test_id).FirstOrDefault();
                //Start_test_q start_Test_q = db.Start_Tests_q.Include(q => q.question ).Where(p => p.id == 2).FirstOrDefault();
                if (start_Test.Start_test_qs[0] == null)
                {
                    MessageBox.Show("Данные введены ошибочно");
                }
                Start_test_qs = start_Test.Start_test_qs; //сохрание списка вопросов
            }
            catch
            {
                MessageBox.Show("Тест загружается");
            }

        }
        private void Table_refresh(int a = 0)
        {
            if (otvet1.Checked == true)
            {
                CheckAnswer(otvet1.Text);
            }
            else if (otvet2.Checked == true)
            {
                CheckAnswer(otvet2.Text);
            }
            else if (otvet3.Checked == true)
            {
                CheckAnswer(otvet3.Text);
            }
            textv1.Text = (a+1) + ")   " + Start_test_qs[a].question.name;
            Start_test_q start_Test_Q = db.Start_Tests_q.FirstOrDefault(g => g.id == Start_test_qs[a].question.id);
            int a1 = start_Test_Q.id;
            Answer answer = db.Answers.FirstOrDefault(p => p.Questionid == a1);
            int q1 = answer.id;
            if (start_Test_Q.id == answer.Questionid)
            {
                otvet1.Text = answer.name;
                answer.name = otvet1.Text;
                Answer answer2 = db.Answers.FirstOrDefault(p => p.id == q1 + 1);
                otvet2.Text = answer2.name;
                answer2.name = otvet2.Text;
                Answer answer3 = db.Answers.FirstOrDefault(p => p.id == q1 + 2);
                otvet3.Text = answer3.name;
                answer3.name = otvet3.Text;
            }
            sledvopros.Text = "Следующий вопрос";
            //если у строчки с айди стоит верность 1, то плюс балл
            tekuhiy_q = a;
        }
        private void CheckAnswer(string text)
        {
            Start_test_q start_Test_Q1 = db.Start_Tests_q.FirstOrDefault(g => g.id == Start_test_qs[tekuhiy_q].question.id);
            Answer[] answer1 = db.Answers.Where(p => p.Questionid == start_Test_Q1.id).ToArray();
            int c = 0;
            int answerId = 0;
            for (int i = 0; i < answer1.Length; i++)
            {
                if (answer1[i].name == text)
                {
                    answerId = answer1[i].id;
                    c = i;
                    break;
                }
            }
            MessageBox.Show($"{answerId} : {text} : {answer1[c].name}");
            Start_test_qs[tekuhiy_q].user_answer = answerId;
            start_Test_Q1.user_answer = answerId;
            db.SaveChanges();
        }
        private void Test_window_Load(object sender, EventArgs e)
        {
            Table_refresh();
        }
        
        private void zakonchit_Click(object sender, EventArgs e)
        {
            foreach (Start_test_q item in Start_test_qs) //перебирает
            {
                
                Start_test_q start_Test_Q22 = db.Start_Tests_q.FirstOrDefault(g => g.id == item.user_answer);
                if (start_Test_Q22 == null)
                {
                    continue;
                }
                Answer answer_ = db.Answers.Where(p => p.id == item.user_answer).FirstOrDefault();
                if (answer_.vernost == 1)
                {
                    rez++;
                }
            }
            Start_test start_Test = db.Start_Tests.FirstOrDefault(p => p.id == User_info.active_test_id);
            start_Test.resultat = rez;
            db.SaveChanges();

            DialogResult resulttt = MessageBox.Show("Уверены, что хотите закончить тест?", "Выход", MessageBoxButtons.YesNo);
            if (resulttt == DialogResult.Yes)
            {
                MessageBox.Show("Количество правильных ответов: " + rez + " из 8-ми", "Итоги теста");
                MessageBox.Show("Возвращаемся к тестам");
                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
                th.Start();
                this.TopMost = true; //открытие формы "самой верхней формой"
            }
        }
        private void open(object obj)
        {
            Application.Run(new Students_acc());
        }

        private void vopros1_Click(object sender, EventArgs e)
        {
           Table_refresh(0);
        }

        private void vopros2_Click(object sender, EventArgs e)
        {
           Table_refresh(1);
        }

        private void vopros3_Click(object sender, EventArgs e)
        {
            Table_refresh(2);
        }

        private void vopros4_Click(object sender, EventArgs e)
        {
            Table_refresh(3);
        }

        private void vopros5_Click(object sender, EventArgs e)
        {
            Table_refresh(4);
        }

        private void vopros6_Click(object sender, EventArgs e)
        {
            Table_refresh(5);
        }

        private void vopros7_Click(object sender, EventArgs e)
        {
            Table_refresh(6);
        }

        private void vopros8_Click(object sender, EventArgs e)
        {
            Table_refresh(7);
        }

        private void sledvopros_Click(object sender, EventArgs e)
        {
            int b = tekuhiy_q;
            b++;
            if (b == 8)
            {
                b = 0;
            }
            Table_refresh(b);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
