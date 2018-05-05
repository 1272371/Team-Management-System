using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Management_System.Models
{
    public class Team
    {
        [Key]
        public int team_ID { get; set; }
     
        public string team_name { get; set; }
        public int game_ID { get; set; }
        public ICollection<Game> Games { get; set; }
        public ICollection<Member> Members { get; set; }

       



    }
}
