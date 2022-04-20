using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Models
{
    public interface IBowlerRepository
    {
        IQueryable<Bowler> Bowlers { get; }

        public void SaveBowler(Bowler p);
        public void CreateBowler(Bowler p);
        public void DeleteBowler(Bowler p);
        public void UpdateBowler(Bowler p);
    }
}
