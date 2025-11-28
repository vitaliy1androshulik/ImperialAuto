using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Infrastructure.Database
{
    public class ImperialAutoDbContextFactory : IDesignTimeDbContextFactory<ImperialAutoDbContext>
    {
        public ImperialAutoDbContext CreateDbContext(string[] args)
        {
            var connectionString =
                ConfigurationManager.ConnectionStrings["NeontechConnection"]?.ConnectionString;

            var optionsBuilder = new DbContextOptionsBuilder<ImperialAutoDbContext>();
            optionsBuilder.UseNpgsql(connectionString);

            return new ImperialAutoDbContext(optionsBuilder.Options);
        }
    }
}
