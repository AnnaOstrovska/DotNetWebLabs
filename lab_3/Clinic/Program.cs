using BLL.Interfaces;
using DAL.EF;
using DAL.Interfaces;
using DAL.Models;
using DAL.Repositories;
using DAL.UoW;

namespace Hotel
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var typeOfLab = "console";

            switch (typeOfLab)
            {
                case "console":
                    CreateHostBuilder(args).Build().Run();
                    break;
                case "web":
                    CreateHostBuilderWeb(args).Build().Run();
                    break;
                default:
                    break;
            }

        }
        
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<ClinicDbContext>();
                    services.AddScoped<IRepository<CardVisitData>, Repository<CardVisitData>>();
                    services.AddScoped<IRepository<Doctor>, Repository<Doctor>>();
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                });
        
        public static IHostBuilder CreateHostBuilderWeb(string[] args) =>
                    Host.CreateDefaultBuilder(args)
                        .ConfigureWebHostDefaults(webBuilder =>
                        {
                            webBuilder.UseStartup<Startup>();
                        });
    }

}