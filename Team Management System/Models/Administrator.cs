using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Management_System.Models
{
    public class Administrator
    {
     [Key]
        public int Adminstrator_ID { get; set; }
        public string Adminstrator_username { get; set; }
        public string Adminstrator_password { get; set; }
        public string Adminstrator_lastname { get; set; }
        public string Adminstrator_firstname { get; set; }


       
    }
}
