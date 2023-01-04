using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabota.Entity
{
    public class Start_test_q
    {
        public int id { get; set; }
        public int user_answer { get; set; }

        public Start_test start_Test { get; set; }

        public Question question { get; set; }

    }
}
