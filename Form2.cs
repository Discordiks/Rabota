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

namespace Rabota
{
    public partial class Form2 : Form
    {
        ApplicationContext db = new ApplicationContext();
        public Form2()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            User user_e = db.Users.FirstOrDefault(u => u.email == RegEmail.Text);
            if (user_e != null)
            {
                MessageBox.Show("Данная почта уже используется");
                return;
            }
            User user = new User();
            user.email = RegEmail.Text;
            user.password = BCrypt.Net.BCrypt.HashPassword(RegPas.Text); //fishiruem parol
            user.reg_date = DateTime.Now;
            //user.age = 18;
            user.fam = Regfam.Text;
            user.ima = Regima.Text;
            user.otch = Regotch.Text;
            //user.datahb = Convert.ToDateTime(Regdatahb.Text);
            user.datahb = DateTime.Parse(Regdatahb.Text);

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Регистрация прошла успешно");
        }
    }
}
