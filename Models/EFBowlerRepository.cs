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

        public void SaveBowler(Bowler p)
        {
            _context.SaveChanges();
        }

        public void CreateBowler(Bowler p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void DeleteBowler(Bowler p)
        {
            _context.Remove(p);
            _context.SaveChanges();
        }

        public void UpdateBowler(Bowler p)
        {
            _context.Update(p);
        }
    }
}
