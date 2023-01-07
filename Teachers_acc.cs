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
    public partial class Teachers_acc : Form
    {
        ApplicationContext db = new ApplicationContext();
        Thread th;
        public Teachers_acc()
        {
            InitializeComponent();
        }

        private void voprosiks_Click(object sender, EventArgs e) 
        {
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
        }
        private void open(object obj)
        {
            Application.Run(new Vopros());
        }
        

            private void exit_Click(object sender, EventArgs e)
        {
            DialogResult resulttt = MessageBox.Show("Уверены, что хотите выйти?", "Выход", MessageBoxButtons.YesNo);
            if (resulttt == DialogResult.Yes)
            {

                this.Close();
                th = new Thread(open_Log_in);
                th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
                th.Start();

            }

            this.TopMost = true; //открытие формы "самой верхней формой"
        }
        private void open_Log_in(object obj)
        {
            Application.Run(new Log_in());
        }

        private void matem_Click(object sender, EventArgs e)
        {

        }

        private void Teachers_acc_Load(object sender, EventArgs e)
        {
            fio.Text = User_info.user_ima;
        }
    }
}
