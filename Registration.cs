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
    public partial class Registration : Form
    {
        ApplicationContext db = new ApplicationContext();
        public Registration()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            try
            {


                User user_e = db.Users.FirstOrDefault(u => u.email == RegEmail.Text);
                if (user_e != null)
                {
                    MessageBox.Show("Данная почта уже используется");
                    return;
                }

                User user = new User();
                user.email = RegEmail.Text;
                user.password = BCrypt.Net.BCrypt.HashPassword(RegPas.Text); //меняем пароль
                user.reg_date = Convert.ToDateTime(DateTime.Now);
                user.fam = Regfam.Text;
                user.ima = Regima.Text;
                user.otch = Regotch.Text;
                user.datahb = DateTime.Parse(Regdatahb.Text);

                //if (RegEmail.Text == null && RegPas.Text == "" & Regfam.Text == "" & Regima.Text == "" & Regdatahb.Text == "")
                //{
                //    MessageBox.Show("Введите все данные");
                //}
                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");


            }
            catch (Exception ef)
            {
                ef.Data.Add("user", Thread.CurrentPrincipal.Identity.Name);
               
                MessageBox.Show("Введите дату");
                
            }
            
        }
    }
}
