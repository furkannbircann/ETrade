using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETrade.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETrade.Persistance
{
    public class DesingTimeDbContextFactory : IDesignTimeDbContextFactory<ETradeContext>
    {
        public ETradeContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ETradeContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configuration.ConnectionString);
            return new(dbContextOptionsBuilder.Options);
        }
    }
}
