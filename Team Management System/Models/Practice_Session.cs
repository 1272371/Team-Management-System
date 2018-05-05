using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Management_System.Models
{
    public class Practice_Session
{
        [Key]
    public int practiceSession_ID { get; set; }
    public string practice_score { get; set; }
    public string practice_time { get; set; }
    public int team_id { get; set; }
        public ICollection<Team> Teams { get; set; }
    }
}
