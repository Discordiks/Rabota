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
        int quection_count;
        int correct_answers;
        int wrong_answers;

        string[] array;

        int correct_answers_number;
        int selected_response;


        System.IO.StreamReader Read;
        public Test_window()
        {
            InitializeComponent();
        }
        private void Table_refresh()
        {
            db.Questions.Include(t1 => t1.Type_Question).Load();
            db.Questions.Include(t2 => t2.Test).Load();

            Random rand = new Random();
            int toSkip = rand.Next(0, db.Questions.Count());
            db.Questions.Skip(toSkip).Take(1).First();
            Question question = db.Questions.FirstOrDefault(q => q.id == toSkip);
            textv1.Text = question.name;
            question.name = textv1.Text;

            int a1 = Convert.ToInt32(question.id);
            Answer answer = db.Answers.FirstOrDefault(p => p.Questionid == a1);
            int q1 = Convert.ToInt32(answer.id);
            if (question.id == answer.Questionid)
            {
                otvet1.Text = answer.name;
                answer.name = otvet1.Text;
                Answer answer2 = db.Answers.FirstOrDefault(p => p.id == q1 + 1);
                otvet2.Text = answer2.name;
                answer2.name = otvet2.Text;
                Answer answer3 = db.Answers.FirstOrDefault(p => p.id == q1 + 2);
                otvet3.Text = answer3.name;
                answer3.name = otvet3.Text;
            }
            //Name = Convert.ToString(db.Questions.OrderBy(r => Guid.NewGuid()).Skip(toSkip).Take(1).First());
            //создать таблицу тест, в которые я рандомно занесу вопросы с ответами, где 

            //try
            //{
            //    string result = com.ExecuteScalar().ToString();
            //}
            //catch (NullReferenceException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
        }

        private void Test_window_Load(object sender, EventArgs e)
        {
            //radioButton1.CheckedChanged += new EventHandler(состаяниеперключение);
            //radioButton2.CheckedChanged += new EventHandler(состаяниеперключение);
            //radioButton3.CheckedChanged += new EventHandler(состаяниеперключение);
            //start();
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

        void start()
        {
            //var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                //Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory()+@"\t.txt", Encoding);
                //this.Text = Read.ReadLine();

                quection_count = 0;
                correct_answers = 0;
                wrong_answers = 0;

                array = new String[8];
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");
            }
            vopros();

        }
        void vopros()
        {
            textv1.Text = Read.ReadLine();

            otvet1.Text = Read.ReadLine();
            otvet2.Text = Read.ReadLine();
            otvet3.Text = Read.ReadLine();

            correct_answers_number = int.Parse(Read.ReadLine());

            otvet1.Checked = false;
            otvet2.Checked = false;
            otvet3.Checked = false;

            sledvopros.Enabled = false;
            quection_count = quection_count + 1;

            if (Read.EndOfStream == true) sledvopros.Text = "Завершить";

        }
        void состаяниеперключение(object sender, EventArgs e)
        {

            sledvopros.Enabled = true;
            sledvopros.Focus();
            RadioButton Переключатель = (RadioButton)sender;
            var tmp = Переключатель.Name;

            selected_response = int.Parse(tmp.Substring(11));
        }
        private void sledvopros_Click(object sender, EventArgs e)
        {
            if (selected_response == correct_answers_number) correct_answers =
                                              correct_answers + 1;
            if (selected_response != correct_answers_number)
            {

                wrong_answers = wrong_answers + 1;

                array[wrong_answers] = textv1.Text;
            }
            if (sledvopros.Text == "Начать тестирование сначала")
            {
                sledvopros.Text = "Следующий вопрос";

                otvet1.Visible = true;
                otvet2.Visible = true;
                otvet3.Visible = true;

                start(); return;
            }
            if (sledvopros.Text == "Завершить")
            {

                Read.Close();

                otvet1.Visible = false;
                otvet2.Visible = false;
                otvet3.Visible = false;

                textv1.Text = String.Format("Тестирование завершено.\n" +
                    "Правильных ответов: {0} из {1}.\n" +
                    "Набранные балы: {2:F2}.", correct_answers,
                    quection_count, (correct_answers * 5.0F) / quection_count);

                sledvopros.Text = "Начать тестирование сначала";

                var Str = "Список ошибок " +
                          ":\n\n";
                for (int i = 1; i <= wrong_answers; i++)
                    Str = Str + array[i] + "\n";


                if (wrong_answers != 0) MessageBox.Show(
                                          Str, "Тестирование завершено");
            }
            if (sledvopros.Text == "Следующий вопрос") vopros();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vopros1_Click(object sender, EventArgs e)
        {
            if (textv1.Text == "1")
            {
                Table_refresh();
            }
            //otvet1.Visible = true;
            //otvet2.Visible = true;
            //otvet3.Visible = true;
        }

        private void vopros2_Click(object sender, EventArgs e)
        {
            if (textv2.Text == "2")
            {
                Table_refresh();
            }
        }

        private void vopros3_Click(object sender, EventArgs e)
        {
            if (textv3.Text == "3")
            {
                Table_refresh();
            }
        }

        private void vopros4_Click(object sender, EventArgs e)
        {
            if (textv4.Text == "4")
            {
                Table_refresh();
            }
        }

        private void vopros5_Click(object sender, EventArgs e)
        {
            if (textv5.Text == "5")
            {
                Table_refresh();
            }
        }

        private void vopros6_Click(object sender, EventArgs e)
        {
            if (textv6.Text == "6")
            {
                Table_refresh();
            }
        }

        private void vopros7_Click(object sender, EventArgs e)
        {
            if (textv7.Text == "7")
            {
                Table_refresh();
            }
        }

        private void vopros8_Click(object sender, EventArgs e)
        {
            if (textv8.Text == "8")
            {
                Table_refresh();
            }
        }
    }
}
