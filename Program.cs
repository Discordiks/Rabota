using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Rabota.Entity;
using System.Text;
using System.Data;

namespace Rabota
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Vopros());

            ApplicationContext db = new ApplicationContext();

            if (db.Type_Questions == null)
            {
                // создание категорий
                Type_question c1 = new Type_question();
                Type_question c2 = new Type_question();
                Type_question c3 = new Type_question();

                c1.name = "Один вариант ответа";
                c2.name = "Несколько вариантов ответа";
                c3.name = "Самостоятельный ответ";

                //добавление категорий в контекст
                db.Type_Questions.AddRange(c1, c2, c3);


            }
            db.SaveChanges();


        }
    }
   
}

