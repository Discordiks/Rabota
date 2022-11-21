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
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick1);
            
        }
        private void Table_refresh()
        {
            db.Questions.Include(t1=>t1.Type_Question).Load();
            db.Questions.Include(t2=>t2.Test).Load();
            dataGridView1.DataSource = db.Questions.Local.ToBindingList();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combotypeq.DataSource = db.Type_Questions.ToList();
            combotypeq.DisplayMember = "name";
            combotypeq.ValueMember = "id";

            combotestq.DataSource = db.Tests.ToList();
            combotestq.DisplayMember = "result";
            combotestq.ValueMember = "id";

            Table_refresh();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            // Удаление
            int s = Convert.ToInt32(kod1.Text);
            // получаем первый объект
            Question question = db.Questions.FirstOrDefault(q => q.id == s);
            if (question != null)
            {
            //удаляем объект
              db.Questions.Remove(question);
              db.SaveChanges();
            }
            // выводим данные после обновления
            MessageBox.Show("Данные удалены успешно");
            var questions = db.Questions.ToList();
                
            Table_refresh();
        }

        private void create_Click(object sender, EventArgs e)
        {
            //Question tom = new Question { name = nameq.Text, Type_questionid = combotypeq.SelectedIndex, Testid = combotestq.SelectedIndex};  
           
            // Добавление
            //db.Questions.Add(tom);
            //db.SaveChanges();
            
            //MessageBox.Show("Данные добавлены успешно");
            //Table_refresh();
        }
        private void ClearData1()
        {
            ;
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
                Table_refresh();
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
