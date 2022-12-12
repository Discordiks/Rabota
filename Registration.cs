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
            User user_e = db.Users.FirstOrDefault(u => u.email == RegEmail.Text);
            if (user_e != null)
            {
                MessageBox.Show("Данная почта уже используется");
                return;
            }
            try
            {
                User user = new User();
                user.email = RegEmail.Text;
                user.password = BCrypt.Net.BCrypt.HashPassword(RegPas.Text); //меняем пароль
                user.reg_date = Convert.ToDateTime(DateTime.Now);
                user.fam = Regfam.Text;
                user.ima = Regima.Text;
                user.otch = Regotch.Text;
                user.datahb = DateTime.Parse(Regdatahb.Text);

                db.Users.Add(user);
                db.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");

            }
            catch
            {
                MessageBox.Show("Заполните все поля!");
            }
            
                //if (RegEmail.Text == null)
                //{
                //    MessageBox.Show("Заполните все поля!");
                //};
                MessageBox.Show("Введите дату в номарльной форме!");
           
           // MessageBox.Show("Регистрация прошла успешно");
        }
    }
}
