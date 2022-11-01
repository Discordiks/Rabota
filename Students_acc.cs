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
    public partial class Students_acc : Form
    {
        ApplicationContext db = new ApplicationContext();
        //Test_window f4;
        Thread th;
        public Students_acc()
        {
            InitializeComponent();
        }
        private void open(object obj)
        {
            Application.Run(new Test_window());
        }
        private void open1(object obj)
        {
            Application.Run(new Log_in());
        }
        private void matem_Click(object sender, EventArgs e)
        {

            //Question question = new Question();
            //question.name = "";


            //db.Questions.Add(question);
            //db.SaveChanges();
            MessageBox.Show("Открытие теста по математике");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }
        

        private void rus_z_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открытие теста по русскому");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }

        private void liter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открытие теста по литературе");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }

        private void genshin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Открытие ГЕНШИНАААА");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult resulttt = MessageBox.Show("Уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (resulttt == DialogResult.Yes)
            {
                
                this.Close();
                th = new Thread(open1);
                th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
                th.Start();

            }
                
            this.TopMost = true; //открытие формы "самой верхней формой"


        }
    }
}
