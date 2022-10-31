using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rabota.Entity;
using System.Windows.Forms;

namespace Rabota.Entity
{
    public class User
    {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime reg_date { get; set; }
        public string fam { get; set; }
        public string ima { get; set; }
        public string otch { get; set; }
        //public DateTime datahb { get; set; }

    }
}
