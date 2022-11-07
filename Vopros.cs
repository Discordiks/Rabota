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
        
        
        private SQLiteConnection connection;
        int ID1 = 0;
        public Vopros()
        {
            InitializeComponent();
            dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick1);
            
        }
        private void Table_refresh()
        {
            this.connection.Open();
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT * FROM Questions ORDER BY RAND() LIMIT 2; ", this.connection);
            DataSet data = new DataSet();
            adapter.Fill(data);
            dataGridView1.DataSource = data.Tables[0].DefaultView;
            this.connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SQLiteConnection("Data Source=App.sqlite");
            this.Table_refresh();
        }

      

        private void delete_Click(object sender, EventArgs e)
        {
            //удалить - вопросы
            int s = Convert.ToInt32(kod1.Text);
            this.connection.Open();
            SQLiteCommand _command = new SQLiteCommand("DELETE FROM Questions WHERE id = " + s, connection);
            int count_add = _command.ExecuteNonQuery();
            this.connection.Close();
            Table_refresh();
        }

        private void create_Click(object sender, EventArgs e)
        {
            //добавить - вопросы
            this.connection.Open();
            string label1 = nameq.Text;
            string label2 = typeq.Text;
            string label3 = testq.Text;
            string sql = "INSERT INTO Questions(name, type_id, test_id) VALUES(@label1,@label2, @label3)";
            SQLiteCommand _command = new SQLiteCommand(sql, connection);
            SQLiteParameter param1 = new SQLiteParameter("@label1", label1);
            SQLiteParameter param2 = new SQLiteParameter("@label2", label2);
            SQLiteParameter param3 = new SQLiteParameter("@label3", label3);
            _command.Parameters.Add(param1);
            _command.Parameters.Add(param2);
            _command.Parameters.Add(param3);

            int count_add = _command.ExecuteNonQuery();
            if (count_add > 0)
            {
                MessageBox.Show("Добавлен");
            }
            this.connection.Close();
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
            //изменить - вопросы
            if (nameq.Text != "" && typeq.Text != "" && testq.Text != "")
            {
                this.connection.Open();
                SQLiteCommand command = new SQLiteCommand("UPDATE Questions SET name = @nameq, type_id = @typeq, test_id = @testq WHERE id=@kodq", connection);

                command.Parameters.AddWithValue("@kodq", ID1);
                command.Parameters.AddWithValue("@nameq", nameq.Text);
                command.Parameters.AddWithValue("@typeq", typeq.Text);
                command.Parameters.AddWithValue("@testq", testq.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Запись успешно обновлена");
                this.connection.Close();
                Table_refresh();
                ClearData1();

            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите запись для обновления");
            }
        }
    }
}
