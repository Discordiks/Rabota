using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabota.Entity
{
    public class Answer
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string name { get; set; }
        
        public int Questionid { get; set; }

        public virtual Question Question { get; set; }    // навигационное свойство

        public virtual string Question_name
        {
            get
            {
                return Question.name;
            }

        }
        public int vernost { get; set; }
    }
}
