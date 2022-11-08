using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabota.Entity
{
    public class Question
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string name { get; set; }

        public int Type_questionid { get; set; }
        public virtual Type_question Type_Question  { get; set; }    // навигационное свойство

        public virtual string Type_Question_name
        {
            get
            {
                return Type_Question.name;
            }
            
        }
        public int test_id { get; set; }

    }
}
