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
    public partial class Itogi_testov : Form
    {
        ApplicationContext db = new ApplicationContext();
        Thread th;
        public Itogi_testov()
        {
            InitializeComponent();
        }
        private void Table_refresh()
        {
            //db.Start_Tests_q.Include(t1 => t1.start_Test).Load();
            //db.Start_Tests_q.Include(t2 => t2.question).Load();
            //Start_test_q st = db.Start_Tests_q.Local.Where(p => p.question.Testid == 1).FirstOrDefault();
            //dataGridView1.DataSource = db.Start_Tests.ToList();
            //dataGridView3.DataSource = data;
            //dataGridView4.DataSource = data;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void Itogi_testov_Load(object sender, EventArgs e)
        {
            Table_refresh();
        }
    }
}
