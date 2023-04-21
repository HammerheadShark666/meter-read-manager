using MeterReadManager.Domain;
using Microsoft.EntityFrameworkCore;

namespace MeterReadManager.Data;

public class MeterReadManagerContext : DbContext
{
    //UNCOMMENT OUT WHEN RUNNING FOR MIGRATIONS
    //      public MeterReadManagerContext()
    //      {

    //      }

    //      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //      {
    //         	optionsBuilder.UseSqlServer("Server=tcp:swansong-sql-server-uat.database.windows.net;Initial Catalog=swansong-db;Persist Security Info=False;User ID=SwanSongAdmin;Password=lawandorder66#3;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
    //          // optionsBuilder.UseSqlServer("Initial Catalog=SwanSongDB; Data Source=localhost, 1440; Persist Security Info=True;User ID=SA;Password=Rcu9OP443mc#3xx;");
    //}

    public MeterReadManagerContext(DbContextOptions<MeterReadManagerContext> options)
        : base(options)
    {
    }

    public DbSet<Account> Accounts { get; set; }
    public DbSet<County> Counties { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Meter> Meters { get; set; }
    public DbSet<MeterReading> MeterReadings { get; set; }
    public DbSet<MeterType> MeterTypes { get; set; }
    public DbSet<ReadingLog> ReadingLogs { get; set; }          

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); 

        modelBuilder.Entity<Country>().HasData(DefaultData.Lookups.GetCountryDefaultData());
        modelBuilder.Entity<County>().HasData(DefaultData.Lookups.GetCountyDefaultData());
        modelBuilder.Entity<MeterType>().HasData(DefaultData.Lookups.GetMeterTypeDefaultData());
        modelBuilder.Entity<Customer>().HasData(DefaultData.Customers.GetCustomerDefaultData());
        modelBuilder.Entity<Meter>().HasData(DefaultData.Meters.GetMeterDefaultData());
        modelBuilder.Entity<Account>().HasData(DefaultData.Accounts.GetAccountDefaultData());
    }
}


//Add-Migration Create-db
//update-database   

//EntityFrameworkCore\Add-Migration create-db
//EntityFrameworkCore\update-database 