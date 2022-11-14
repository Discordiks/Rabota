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
    public partial class Vopros : Form
    {

        ApplicationContext db = new ApplicationContext();
        int ID1 = 0;
        public Vopros()
        {
            InitializeComponent();
            //dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick1);
            
        }
        private void Table_refresh()
        {
            db.Questions.Include(t=>t.Type_Question).Load();
            dataGridView1.DataSource = db.Questions.Local.ToBindingList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Table_refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
           
            Table_refresh();
        }

        private void create_Click(object sender, EventArgs e)
        {
            
            Table_refresh();
        }
        private void ClearData1()
        {
            ID1 = 0;
            nameq.Text = "";
            typeq.Text = "";
            testq.Text = "";
        }
        private void dataGridView1_RowHeaderMouseClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameq.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            typeq.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            testq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void change_Click(object sender, EventArgs e)
        {
            
            if (nameq.Text != "" && typeq.Text != "" && testq.Text != "")
            {
                
                ClearData1();

            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для обновления");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
