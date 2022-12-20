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
        //int cur = 0;

        public Test_window()
        {
            InitializeComponent();
        }
        private void Table_refresh()
        {
            db.Questions.Include(t1 => t1.Type_Question).Load();
            db.Questions.Include(t2 => t2.Test).Load();

            Random rand = new Random();
            int toSkip = rand.Next(0, db.Questions.Count());
            db.Questions.Skip(toSkip).Take(1).First();
            Question question = db.Questions.FirstOrDefault(q => q.id == toSkip);
            textv1.Text = question.name;
            question.name = textv1.Text;

            int a1 = Convert.ToInt32(question.id);
            Answer answer = db.Answers.FirstOrDefault(p => p.Questionid == a1);
            int q1 = Convert.ToInt32(answer.id);
            if (question.id == answer.Questionid)
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vopros1_Click(object sender, EventArgs e)
        {
            if (textv1.Text == "1")
            {
                Table_refresh();
            }
            //otvet1.Visible = true;
            //otvet2.Visible = true;
            //otvet3.Visible = true;
        }

        private void vopros2_Click(object sender, EventArgs e)
        {
            if (textv2.Text == "2")
            {
                //Table_refresh();
            }
        }

        private void vopros3_Click(object sender, EventArgs e)
        {
            if (textv3.Text == "3")
            {
                //Table_refresh();
            }
        }

        private void vopros4_Click(object sender, EventArgs e)
        {
            if (textv4.Text == "4")
            {
                //Table_refresh();
            }
        }

        private void vopros5_Click(object sender, EventArgs e)
        {
            if (textv5.Text == "5")
            {
                //Table_refresh();
            }
        }

        private void vopros6_Click(object sender, EventArgs e)
        {
            if (textv6.Text == "6")
            {
                //Table_refresh();
            }
        }

        private void vopros7_Click(object sender, EventArgs e)
        {
            if (textv7.Text == "7")
            {
                //Table_refresh();
            }
        }

        private void vopros8_Click(object sender, EventArgs e)
        {
            if (textv8.Text == "8")
            {
                //Table_refresh();
            }
        }

        private void sledvopros_Click(object sender, EventArgs e)
        {
           
        }
    }
}
