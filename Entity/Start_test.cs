﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabota.Entity
{
    public class Start_test
    {
        public int id { get; set; }
        public int UserId { get; set; }
        public int resultat { get; set; }

        public User user { get; set; }
        public virtual string usersss
        {
            get
            {
                return user.ima + "  ";
            }

        }
        public virtual string usersss1
        {
            get
            {
                return user.fam + "  ";
            }

        }
        public virtual string usersss2
        {
            get
            {
                return user.otch + "  ";
            }

        }
       
        public List<Start_test_q> Start_test_qs { get; set; } = new List<Start_test_q>();



    }
}
