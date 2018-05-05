using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Management_System.Models
{
    public class Player
    {
        [Key]
        public int player_ID { get; set; }

        public int member_ID { get; set; }

        public int team_ID { get; set; }

        public Member Member { get; set; }
        public Team Team { get; set; }

    }
}
