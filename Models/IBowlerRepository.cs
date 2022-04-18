using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowlers { get; }
    }
}
