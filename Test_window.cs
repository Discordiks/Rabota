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
    public partial class Test_window : Form
    {
        //Students_acc f3;
        Thread th;
        public Test_window()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

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

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sledvopros_Click(object sender, EventArgs e)
        {

        }
    }
}
