using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MySQLBowler.Models
{
    public class BowlerDbContext : DbContext
    {
        public BowlerDbContext (DbContextOptions<BowlerDbContext> options) : base (options)
        {

        }
        public DbSet<Bowler> Bowlers { get; set; }
      
    }
}
