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
        //int count = 0;
        public List<Start_test_q> Start_test_qs { get; set; } = new List<Start_test_q>();
        public Test_window()
        {
            InitializeComponent();

            Start_test start_Test = db.Start_Tests.Include(q => q.Start_test_qs).ThenInclude(r => r.question).Where(p => p.id == User_info.active_test_id).FirstOrDefault();
            //Start_test_q start_Test_q = db.Start_Tests_q.Include(q => q.question ).Where(p => p.id == 2).FirstOrDefault();
            if (start_Test.Start_test_qs[0] == null)
            {
                MessageBox.Show("Данные введены ошибочно");
            }
            Start_test_qs = start_Test.Start_test_qs; //сохрание списка вопросов
            MessageBox.Show(Start_test_qs.Count.ToString());
        }
        private void Table_refresh(int a = 0)
        {
            tekuhiy_q = a;
            textv1.Text = (a+1) + ")   " + Start_test_qs[a].question.name;
            Start_test_q start_Test_Q = db.Start_Tests_q.FirstOrDefault(g => g.id == Start_test_qs[a].question.id);
            int a1 = Convert.ToInt32(start_Test_Q.id);
            Answer answer = db.Answers.FirstOrDefault(p => p.Questionid == a1);
            int q1 = Convert.ToInt32(answer.id);
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
            if (otvet1.Checked == true || otvet2.Checked == true || otvet3.Checked == true)
            {
                Start_test_qs[tekuhiy_q].user_answer = answer.id;
                start_Test_Q.user_answer = answer.id;
                db.SaveChanges();
            }
            else
            {
                return;
            }
            //otvet1.Checked = false;
            //otvet2.Checked = false;
            //otvet3.Checked = false;
        }

        private void Test_window_Load(object sender, EventArgs e)
        {
            
            //radioButton1.CheckedChanged += new EventHandler(состаяниеперключение);
            //radioButton2.CheckedChanged += new EventHandler(состаяниеперключение);
            //radioButton3.CheckedChanged += new EventHandler(состаяниеперключение);

            this.Table_refresh();
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
                MessageBox.Show(start_Test_Q22.user_answer.ToString());
                Answer answer_ = db.Answers.Where(p => p.id == item.user_answer).FirstOrDefault();
                if (answer_ == null)
                {
                    continue;
                }
                
                if (answer_.vernost == 1)
                {
                    rez++;
                }

                
            }
            MessageBox.Show("Количество правильных ответов" + rez);

            MessageBox.Show("Вернуться к тестам");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
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
            sledvopros.Text = "Перейти к началу теста";
        }

        private void sledvopros_Click(object sender, EventArgs e)
        {
            tekuhiy_q++;
            if (tekuhiy_q == 8)
            {
                tekuhiy_q = 0;
                
            }
            Table_refresh(tekuhiy_q);
            //if (textv1.Text == (0 + 1) + ")   " + Start_test_qs[0].question.name)
            //{
            //    Table_refresh(1);
            //}
            //else if (textv1.Text == (1 + 1) + ")   " + Start_test_qs[1].question.name)
            //{
            //    Table_refresh(2);
            //}
            //else if (textv1.Text == (2 + 1) + ")   " + Start_test_qs[2].question.name)
            //{
            //    Table_refresh(3);
            //}
            //else if (textv1.Text == (3 + 1) + ")   " + Start_test_qs[3].question.name)
            //{
            //    Table_refresh(4);
            //}
            //else if (textv1.Text == (4 + 1) + ")   " + Start_test_qs[4].question.name)
            //{
            //    Table_refresh(5);
            //}
            //else if (textv1.Text == (5 + 1) + ")   " + Start_test_qs[5].question.name)
            //{
            //    Table_refresh(6);
            //}
            //else if (textv1.Text == (6 + 1) + ")   " + Start_test_qs[6].question.name)
            //{
            //    Table_refresh(7);
            //    sledvopros.Text = "Перейти к началу теста";
            //}
            //else if (textv1.Text == (7 + 1) + ")   " + Start_test_qs[7].question.name)
            //{
            //    Table_refresh(0);
            //}

        }

        //private void otvet1_CheckedChanged(object sender, EventArgs e)
        //{
        //    otvet1.Checked = true;
        //    otvet2.Checked = false;
        //    otvet3.Checked = false;
        //}

        //private void otvet2_CheckedChanged(object sender, EventArgs e)
        //{
        //    otvet1.Checked = false;
        //    otvet2.Checked = true;
        //    otvet3.Checked = false;
        //}

        //private void otvet3_CheckedChanged(object sender, EventArgs e)
        //{
        //    otvet1.Checked = false;
        //    otvet2.Checked = false;
        //    otvet3.Checked = true;
        //}
    }
}
