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
    public partial class Log_in : Form
    {

        ApplicationContext db = new ApplicationContext();
        Registration f2;
        Thread th;
        public Log_in()
        {
            InitializeComponent();
        }

        private void logi_Click(object sender, EventArgs e) //ищем пользователя, чтобы найти кэш
        {
            User user = db.Users.FirstOrDefault(u => u.email == outemail.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            if (BCrypt.Net.BCrypt.Verify(outpass.Text, user.password))
            {
                MessageBox.Show("Всё верно, проходите");

                this.Close();
                th = new Thread(open);
                th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
                th.Start();
                return;
            }
            MessageBox.Show("Пароль введён неправильно");
            
        }

        private void sozdatakk_Click(object sender, EventArgs e)
        {
            f2 = new Registration();
            f2.Show();
        }
        private void open(object obj)
        {
            Application.Run(new Students_acc());
        }

        private void Log_in_Load(object sender, EventArgs e)
        {

        }
    }
}


