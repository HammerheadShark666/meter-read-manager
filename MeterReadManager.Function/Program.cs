using FluentValidation;
using MeterReadManager.Business.Validator;
using MeterReadManager.Data;
using MeterReadManager.Data.Repository;
using MeterReadManager.Data.Repository.Interface;
using MeterReadManager.Data.UnitOfWork;
using MeterReadManager.Data.UnitOfWork.Interfaces;
using MeterReadManager.Helper;
using MeterReadManager.Helper.Interface;
using MeterReadManager.Service;
using MeterReadManager.Service.Interface;
using MeterReadManager.Service.Interface.MeterReader;
using MeterReadManager.Service.MeterReader;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Diagnostics;
using System.Reflection;

Debugger.Launch();

IConfiguration configuration = new ConfigurationBuilder()
   .AddJsonFile("local.settings.json", true, true)
   .AddEnvironmentVariables()
   .Build();

var host = new HostBuilder()
    .ConfigureFunctionsWorkerDefaults()
    .ConfigureServices(s =>
    { 
        s.AddTransient<IAccountRepository, AccountRepository>();
        s.AddTransient<ICustomerRepository, CustomerRepository>();
        s.AddTransient<ICountyRepository, CountyRepository>();
        s.AddTransient<IMeterRepository, MeterRepository>();
        s.AddTransient<IMeterReadingRepository, MeterReadingRepository>();
        s.AddTransient<IMeterReaderMetersToReadService, MeterReaderMetersToReadService>();
        s.AddTransient<IReadingLogRepository, ReadingLogRepository>();
        s.AddTransient<IAccountService, AccountService>();
        s.AddTransient<IAuthenticateService, AuthenticateService>();
        s.AddTransient<ICustomerService, CustomerService>();
        s.AddTransient<ICountyService, CountyService>();
        s.AddTransient<IMeterService, MeterService>();
        s.AddTransient<IMeterReadingService, MeterReadingService>();
        s.AddTransient<IReadingLogService, ReadingLogService>();
        s.AddTransient<IMeterReaderReadMeterSimulator, MeterReaderReadMeterSimulatorService>();
        s.AddTransient<IMeterReaderSaveMeterReadingService, MeterReaderSaveMeterReadingService>();
        s.AddTransient<IMeterReaderFailedMeterReadingService, MeterReaderFailedMeterReadingService>();
        s.AddTransient<IMeterReaderReadMeterService, MeterReaderReadMeterService>();
        s.AddTransient(typeof(IDeserializeToObject<>), typeof(DeserializeToObject<>));
        s.AddTransient<IUnitOfWork, UnitOfWork>();        
        s.AddValidatorsFromAssemblyContaining<AccountValidator>();         
        s.AddAutoMapper(Assembly.GetAssembly(typeof(AutoMapperProfile)));
        s.AddDbContext<MeterReadManagerContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString(Constants.DatabaseConnectionString),
                options => options.EnableRetryOnFailure( 
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(60),
                    errorNumbersToAdd: null
                    )
                .MigrationsAssembly(typeof(MeterReadManagerContext).Assembly.FullName)));

        s.AddMemoryCache();
    })
    .Build();

await host.RunAsync();