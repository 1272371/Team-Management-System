using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Team_Management_System.Models
{
    public class Match_Session
    {
        [Key]
    public int matchSession_ID { get; set; }
    public int matchSession_score { get; set; }
    public int team_ID { get; set; }
    public ICollection<Team> Teams { get; set; }

    }
}
