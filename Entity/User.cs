using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rabota.Entity;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Rabota.Entity
{
    public class User
    {
        public int id { get; set; }

        [Required]
        [Column(TypeName = "varchar(255)")]
        public string email { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string password { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime reg_date { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string fam { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string ima { get; set; }
        [Required]
        [Column(TypeName = "varchar(255)")]
        public string otch { get; set; }
        [Required]
        [Column(TypeName = "DateTime")]
        public DateTime datahb { get; set; }

    }
}
