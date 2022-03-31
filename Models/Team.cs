using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Models
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamID { get; }
        public string TeamName { get; }
        public int CaptainID { get; }
    }
}
