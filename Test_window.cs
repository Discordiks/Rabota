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
    public partial class Test_window : Form
    {
        ApplicationContext db = new ApplicationContext();
        Thread th;
        public Test_window()
        {
            InitializeComponent();
            //dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick1);
        }
        private void Table_refresh()
        {

            db.Questions.Include(t => t.Type_Question).Load();
            dataGridView1.DataSource = db.Questions.Local.ToBindingList();
        }
        private void Test_window_Load(object sender, EventArgs e)
        {
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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sledvopros_Click(object sender, EventArgs e)
        {

        }

        
    }
}
