using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Models
{
    public class EFBowlerRepository : IBowlerRepository
    {
        private BowlerDbContext _context { get; set; }
        public EFBowlerRepository (BowlerDbContext temp)
        {
            _context = temp;
        }
        public IQueryable<Bowler> Bowlers => _context.Bowlers;
    }
}
