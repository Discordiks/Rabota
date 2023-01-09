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
            db.Questions.Include(t1 => t1.Type_Question).Load();
            db.Questions.Include(t2 => t2.Test).Load();
            db.Answers.Include(t1 => t1.Question).Load();

            List<Start_test> start_Tests = db.Start_Tests.Include(st => st.Start_test_qs)
               .ThenInclude(stq => stq.question).Where(st => st.UserId == User_info.user_id)
               .OrderBy(o => o.id).ToList();

            //List<Start_test> start_Tests1 = new List<Start_test>();

            //List<Start_test_q> start_Test_Qs = db.Start_Tests_q.Include(tt => tt.Start_Testsss)
            //   .ThenInclude(tt => tt.resultat).Where(st => st.start_Test.id == User_info.active_test_id)
            //   .OrderBy(o => o.id).ToList();


            //dataGridView1.DataSource = start_Test_Qs.ToList();
            //dataGridView1.DataSource = db.Start_Tests.Local.ToBindingList();
            //Where(l => l.UserId == User_info.user_id)

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Purple;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
