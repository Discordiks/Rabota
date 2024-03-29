﻿using System;
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
        int ID2 = 0;
        Thread th;

        public Vopros()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick1);
            dataGridView2.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView2_RowHeaderMouseClick1);
        }
       
        private void Table_refresh()
        {
            db.Questions.Include(t1=>t1.Type_Question).Load();
            db.Questions.Include(t2=>t2.Test).Load();
            db.Answers.Include(t1 => t1.Question).Load();
            dataGridView1.DataSource = db.Questions.Local.ToBindingList();
            dataGridView2.DataSource = db.Answers.Local.ToBindingList();

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            dataGridView2.DefaultCellStyle.SelectionBackColor = Color.LimeGreen;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            combotypeq.DataSource = db.Type_Questions.ToList();
            combotypeq.DisplayMember = "name";
            combotypeq.ValueMember = "id";

            combotestq.DataSource = db.Tests.ToList();
            combotestq.DisplayMember = "name";
            combotestq.ValueMember = "id";

            comboquestan.DataSource = db.Questions.ToList();
            comboquestan.DisplayMember = "name";
            comboquestan.ValueMember = "id";
            Table_refresh();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                // Удаление из таблицы "Вопросы"
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
            else if (tabControl1.SelectedTab == tabPage2)
            {
                // Удаление из таблицы "Ответы"
                int s1 = Convert.ToInt32(kod1.Text);
                Answer answer = db.Answers.FirstOrDefault(an => an.id == s1);
                if (answer != null)
                {
                    //удаляем объект
                    db.Answers.Remove(answer);
                    db.SaveChanges();
                }
                // выводим данные после обновления
                MessageBox.Show("Данные удалены успешно");
                var answers = db.Answers.ToList();
            }
        }
        private void create_Click(object sender, EventArgs e)
        {
            // Добавление в "Вопросы"
            if (tabControl1.SelectedTab == tabPage1)
            {
                if (nameq.Text != "" )
                {
                    Question tom = new Question { name = nameq.Text, Type_questionid = Convert.ToInt32(combotypeq.SelectedValue.ToString()), Test = db.Tests.Find(Convert.ToInt32(combotestq.SelectedValue.ToString()) )};

                db.Questions.Add(tom);
                db.SaveChanges();
                MessageBox.Show("Данные добавлены успешно");
                ClearData1();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите запись для обновления");
                }
            }
            else if (tabControl1.SelectedTab == tabPage2)
            {
                // Добавление в "Ответы"
                if (nameq.Text != "" )
                {
                    Answer tom = new Answer { name = namean.Text,  Questionid = Convert.ToInt32(comboquestan.SelectedValue.ToString()) };

                db.Answers.Add(tom);
                db.SaveChanges();
                MessageBox.Show("Данные добавлены успешно");
                ClearData2();
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите запись для обновления");
                }
            }
        }
        private void ClearData1()
        {
            ID1 = 0;
            nameq.Text = "";
            combotypeq.Text = "";
            combotestq.Text = "";
        }
        private void ClearData2()
        {
            ID2 = 0;
            namean.Text = "";
            comboquestan.Text = "";
        }
        private void dataGridView1_RowHeaderMouseClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            ID1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            nameq.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            combotypeq.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            combotestq.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void dataGridView2_RowHeaderMouseClick1(object sender, DataGridViewCellMouseEventArgs e)
        {
            ID2 = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            namean.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboquestan.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void change_Click(object sender, EventArgs e)
        {
            //Изменение в "Вопросы"
            try
            {


                if (tabControl1.SelectedTab == tabPage1)
                {
                    if (nameq.Text != "")
                    {
                        dataGridView1.Refresh();
                        Question question = db.Questions.FirstOrDefault(q => q.id == ID1);
                        question.name = nameq.Text;
                        question.Type_questionid = Convert.ToInt32(combotypeq.SelectedValue.ToString());
                        question.Test = db.Tests.Find(Convert.ToInt32(combotestq.SelectedValue.ToString()));

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
                //Изменение в "Ответы"
                else if (tabControl1.SelectedTab == tabPage2)
                {

                    if (namean.Text != "")
                    {
                        dataGridView2.Refresh();
                        Answer answer = db.Answers.FirstOrDefault(an => an.id == ID2);
                        answer.name = namean.Text;
                        answer.Questionid = Convert.ToInt32(combotypeq.SelectedValue.ToString());

                        db.SaveChanges();
                        dataGridView2.Refresh();
                        MessageBox.Show("Данные обновлены успешно");
                        ClearData2();

                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, выберите запись для обновления");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Пожалуйста, выберите запись для обновления");
            }

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
