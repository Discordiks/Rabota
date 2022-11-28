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
            //dataGridView2.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView2_RowHeaderMouseClick1);
        }
        private void Table_refresh()
        {
            db.Questions.Include(t1=>t1.Type_Question).Load();
            db.Questions.Include(t2=>t2.Test).Load();
            dataGridView1.DataSource = db.Questions.Local.ToBindingList();
            dataGridView2.DataSource = db.Users.Local.ToBindingList();

            


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
        }


        private void create_Click(object sender, EventArgs e)
        {
            // Добавление
            Question tom = new Question {name = nameq.Text, Type_questionid = Convert.ToInt32(combotypeq.SelectedValue.ToString()), Testid = Convert.ToInt32(combotestq.SelectedValue.ToString()) };  

            db.Questions.Add(tom);
            db.SaveChanges();
            MessageBox.Show("Данные добавлены успешно");
            ClearData1();
        }
        private void ClearData1()
        {
            
            ID1 = 0;
            nameq.Text = "";
            combotypeq.Text = "";
            combotestq.Text = "";
        }
        private void dataGridView1_RowHeaderMouseClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameq.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            combotypeq.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            combotestq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void change_Click(object sender, EventArgs e)
        {
            //Изменение

            if (nameq.Text != "" )
            {

                Question question = db.Questions.FirstOrDefault(q => q.id == ID1);
                question.name = nameq.Text;
                question.Type_questionid = Convert.ToInt32(combotypeq.SelectedValue.ToString());
                question.Testid = Convert.ToInt32(combotestq.SelectedValue.ToString());

                db.SaveChanges();
                dataGridView1.Refresh();
                MessageBox.Show("Данные обновлены успешно");
                ClearData1();

            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для обновления");
            }
        }

    }
}
