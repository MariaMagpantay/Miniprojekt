using Model;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class TrådContext : DbContext
    {
        public DbSet<Tråd> Tråde => Set<Tråd>();

        public TrådContext(DbContextOptions<TrådContext> options)
           : base(options)
        {
            // Den her er tom. Men ": base(options)" sikre at constructor
            // på DbContext super-klassen bliver kaldt.
        }
    }
}
