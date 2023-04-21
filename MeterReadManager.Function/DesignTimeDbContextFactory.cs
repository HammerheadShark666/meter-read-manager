using MeterReadManager.Data;
using MeterReadManager.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MeterReadManager.Function;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<MeterReadManagerContext>
{
    public MeterReadManagerContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("local.settings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<MeterReadManagerContext>();

        var connectionString = configuration.GetConnectionString(Constants.DatabaseConnectionString); 

        builder.UseSqlServer(connectionString);

        return new MeterReadManagerContext(builder.Options);
    }
}
