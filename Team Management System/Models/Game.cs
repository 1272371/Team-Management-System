using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Management_System.Models
{
    public class Game
    {
        [Key]
        public int game_ID { get; set; }
        public int game_name { get; set; }
        public int game_type { get; set; }

    }
}
