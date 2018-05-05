using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Team_Management_System.Models
{
    public class Member
    {
        [Key]
        public int member_ID { get; set; }
        public string member_lastName { get; set; }
        public string member_FirstName { get; set; }
        public string member_contacNo { get; set; }
        public string member_email { get; set; }
        public string captain_status { get; set; }
        public string member_username { get; set; }
        public string member_password { get; set; }
        public int Adminstrator_ID { get; set; }
        public ICollection<Administrator> Administrator { get; set; }

    }
}