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
using System.Threading; //использование потоков

namespace Rabota
{
    public partial class Form3 : Form
    {
        ApplicationContext db = new ApplicationContext();
        Form4 f4;
        Thread th;
        public Form3()
        {
            InitializeComponent();
        }

        private void matem_Click(object sender, EventArgs e)
        {

            Question question = new Question();
            question.name = "";
            

            db.Questions.Add(question);
            db.SaveChanges();
            MessageBox.Show("Jnrhsdftv ntcn gj vfntvfnbrt");
            this.Close();
            th = new Thread(open);
            th.SetApartmentState(ApartmentState.STA); //модель для запуска потока
            th.Start();
            //f4 = new Form4();
            //f4.Show();
        }
        private void open(object obj)
        {
            Application.Run(new Form4());
        }
    }
}
