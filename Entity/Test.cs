using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabota.Entity
{
    public class Test
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string result { get; set; }
        
    }
}
