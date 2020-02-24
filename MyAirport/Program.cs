using A.MyAirport.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Configuration;
using System.Linq;


namespace A.MyAirport.console
{
    class Program
    {
        public static readonly ILoggerFactory MyAirportLoggerFactory = LoggerFactory.Create(builder => builder.AddConsole());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DbContextOptionsBuilder optionsBuilder = new DbContextOptionsBuilder<MyAirportContext>();
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["MyAirport"].ConnectionString);
            optionsBuilder.UseLoggerFactory(MyAirportLoggerFactory);
            DbContextOptions<MyAirportContext> dbContextOptions = (DbContextOptions<MyAirportContext>)optionsBuilder.Options;
            using (var db = new MyAirportContext(dbContextOptions))
            {

                // Create
                Console.WriteLine("Création du vol TUNISIE123");

                Vol v1 = new Vol()
                {
                    CIE = "TUNISIE",
                    DES = "PARIS",
                    DHC = Convert.ToDateTime("14/01/2020 16:45"),
                    IMM = "RZ62",
                    LIG = "123",
                    PKG = "R52",
                    PAX = 238

                };
                db.Vols.Add(v1);
                db.SaveChanges();
                
                Console.WriteLine(v1.CIE);
                Console.WriteLine("creation du bagage 012387364501");
                Bagage b1 = new Bagage
                {
                    //VOLID = 14,
                    CLASSE = "Y",
                    CODE_IATA = "012387364501",
                    DATA_CREATION = Convert.ToDateTime("14/01/2020 12:52"),
                    DESTINATION = "BEG"

                };
                db.Bagages.Add(b1);
                db.SaveChanges();

                Console.ReadLine();

                // Read

                Console.WriteLine("Voici la liste des vols disponibles");
                var vol = db.Vols
                    .OrderBy(v => v.CIE);
                foreach (var v in vol)
                {
                    Console.WriteLine($"Le vol {v.CIE}{v.LIG} N° {v.VOLID} a destination de {v.DES} part à {v.DHC} heure");
                }
                Console.ReadLine();
                // Update
                // b1.CODE_IATA = "TREZA";
                //b1.SSUR = "AZE";
                Console.WriteLine($"Le bagage {b1.BAGAGEID} est modifié pour être rattaché au vol {v1.VOLID} => {v1.CIE}{v1.LIG}");
                b1.VOLID = v1.VOLID;
                db.SaveChanges();
                

                // Delete vol et bagages du vol
                Console.WriteLine($"Suppression du vol {v1.VOLID} => {v1.CIE}{v1.LIG}");
                db.Remove(v1);
                db.SaveChanges();
                Console.ReadLine();
            }
            
               
                
              
                



        }


    }
}

