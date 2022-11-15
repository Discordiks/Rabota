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
            //dataGridView1.RowHeaderMouseClick += new DataGridViewCellMouseEventHandler(dataGridView1_RowHeaderMouseClick1);
        }
        private void Table_refresh()
        {

            db.Questions.Include(t1 => t1.Type_Question).Load();
            db.Questions.Include(t2 => t2.Test).Load();
            dataGridView1.DataSource = db.Questions.Local.ToBindingList();
        }
        private void Test_window_Load(object sender, EventArgs e)
        {
            sledvopros.Text = "Следующий вопрос";
            zakonchit.Text = "Выход";

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
            var Encoding = System.Text.Encoding.GetEncoding(65001);
            try
            {

                Read = new System.IO.StreamReader(System.IO.Directory.GetCurrentDirectory()+@"\t.txt", Encoding);
                this.Text = Read.ReadLine();

                quection_count = 0;
                correct_answers = 0;
                wrong_answers = 0;

                array = new String[10];
            }
            catch (Exception)
            {
                MessageBox.Show("ошибка 1");
            }
            vopros();

        }
        void vopros()
        {
            label1.Text = Read.ReadLine();

            radioButton1.Text = Read.ReadLine();
            radioButton2.Text = Read.ReadLine();
            radioButton3.Text = Read.ReadLine();

            correct_answers_number = int.Parse(Read.ReadLine());

            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;

            sledvopros.Enabled = false;
            quection_count = quection_count + 1;

            if (Read.EndOfStream == true) sledvopros.Text = "Завершить";

        }
        void состаяниеперключение(object sender, EventArgs e)
        {

            sledvopros.Enabled = true; sledvopros.Focus();
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

                array[wrong_answers] = label1.Text;
            }
            if (sledvopros.Text == "Начать тестирование сначала")
            {
                sledvopros.Text = "Следующий вопрос";

                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton3.Visible = true;

                start(); return;
            }
            if (sledvopros.Text == "Завершить")
            {

                Read.Close();

                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;

                label1.Text = String.Format("Тестирование завершено.\n" +
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

        
    }
}
