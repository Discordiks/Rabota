using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rabota.Entity
{
    public class Question
    {
        public int id { get; set; }
        public string name { get; set; }
        public int type_id { get; set; }
        public int test_id { get; set; }

    }
}
