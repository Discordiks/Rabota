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

namespace Rabota
{
    public partial class Itogi : Form
    {
        ApplicationContext db = new ApplicationContext();
        Thread th;
        public Itogi()
        {
            InitializeComponent();
        }

        private void Itogi_Load(object sender, EventArgs e)
        {
            Table_refresh();
        }
        private void Table_refresh()
        {
            db.Start_Tests.Include(t1 => t1.user).Load();
            db.Questions.Include(t2 => t2.Test).Load();
            db.Answers.Include(t1 => t1.Question).Load();

            List<Start_test> start_Tests = db.Start_Tests.Include(st => st.Start_test_qs)
                .ThenInclude(stq => stq.question).Where(st => st.UserId == User_info.user_id)
                .OrderByDescending(o => o.id).ToList();


            dataGridView1.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 1).ToList();
            dataGridView3.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 2).ToList();
            dataGridView4.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 3).ToList();
            dataGridView5.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 4).ToList();

            DataGridView dg1 = new DataGridView();
            dg1.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 1).ToList();
            DataGridView dg3 = new DataGridView();
            dg3.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 2).ToList();
            DataGridView dg4 = new DataGridView();
            dg4.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 3).ToList();
            DataGridView dg5 = new DataGridView();
            dg5.DataSource = start_Tests.ToList().Where(s => s.Start_test_qs[0].question.Testid == 4).ToList();


            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dataGridView3.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dataGridView4.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dataGridView5.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult resulttt = MessageBox.Show("Вернуться на главный экран?", "Выход", MessageBoxButtons.YesNo);
            if (resulttt == DialogResult.Yes)
            {
                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
                th.Start();
            }
            
        }
        private void open(object obj)
        {
            Application.Run(new Teachers_acc());
        }
    }
}
