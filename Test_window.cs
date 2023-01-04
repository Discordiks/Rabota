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
        public List<Start_test_q> Start_test_qs { get; set; } = new List<Start_test_q>();
        //int cur = 0;

        public Test_window()
        {
            InitializeComponent();

            Start_test start_Test = db.Start_Tests.Include(q => q.Start_test_qs).ThenInclude(r => r.question).Where(p => p.id == User_info.active_test_id).FirstOrDefault();
            //Start_test_q start_Test_q = db.Start_Tests_q.Include(q => q.question ).Where(p => p.id == 2).FirstOrDefault();


            if (start_Test.Start_test_qs[0] == null)
            {
                MessageBox.Show("uasdhfg");
            }
            Start_test_qs = start_Test.Start_test_qs; //сохрание списка вопросов
        }
        private void Table_refresh(int a = 0)
        {
            textv1.Text = Start_test_qs[a].question.name;


            //int a1 = Convert.ToInt32(start_Test_q.id);
            //Answer answer = db.Answers.FirstOrDefault(p => p.Questionid == a1);
            //int q1 = Convert.ToInt32(answer.id);
            //if (start_Test_q.id == answer.Questionid)
            //{
            //    otvet1.Text = answer.name;
            //    answer.name = otvet1.Text;
            //    Answer answer2 = db.Answers.FirstOrDefault(p => p.id == q1 + 1);
            //    otvet2.Text = answer2.name;
            //    answer2.name = otvet2.Text;
            //    Answer answer3 = db.Answers.FirstOrDefault(p => p.id == q1 + 2);
            //    otvet3.Text = answer3.name;
            //    answer3.name = otvet3.Text;
            //}

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
            
                Table_refresh(0);
           
            //otvet1.Visible = true;
            //otvet2.Visible = true;
            //otvet3.Visible = true;
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
            
        }
    }
}
