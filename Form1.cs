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
    public partial class Form1 : Form
    {

        ApplicationContext db = new ApplicationContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            User user_e = db.Users.FirstOrDefault(u => u.email == RegEmail.Text);
            if (user_e != null)
            {
                MessageBox.Show("Pochta yzhe est");
                return;
            }
            User user = new User();
            user.email = RegEmail.Text;
            user.password = BCrypt.Net.BCrypt.HashPassword(RegPas.Text); //fishiruem parol
            user.reg_date = DateTime.Now;
            user.age = 18;
           

            db.Users.Add(user);
            db.SaveChanges();
            MessageBox.Show("Registracia uspeshna");
        }

        private void logi_Click(object sender, EventArgs e) //snachala ichem polzovatela, chtob potom nayti cash
        {
            User user = db.Users.FirstOrDefault(u => u.email == outemail.Text);
            if (user == null)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }
            if (BCrypt.Net.BCrypt.Verify(outpass.Text, user.password))
            {
                MessageBox.Show("Все верно, проходите");
                return;
            }
            MessageBox.Show("ЖУЛИК, УХАДИ!!!");
        }
    }
}
