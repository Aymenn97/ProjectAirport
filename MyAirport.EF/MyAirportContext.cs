using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Configuration;

namespace A.MyAirport.EF
{
    public class MyAirportContext : DbContext
    {
        public  MyAirportContext(DbContextOptions<MyAirportContext> options)
        : base(options)
        { }

        public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        public DbSet<Bagage> Bagages { get; set; }
        public DbSet<Vol> Vols { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyAirport"].ConnectionString);
            optionsBuilder.UseLoggerFactory(MyAirportLoggerFactory);
        }
    }
}
