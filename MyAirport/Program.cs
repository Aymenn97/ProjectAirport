using A.MyAirport.EF;
using System;
using System.Linq;


namespace A.MyAirport.console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using (var db = new MyAirportContext())
            {


                Vol v1 = new Vol()
                {
                    CIE = 1,
                    LIG = "abcd",
                    JEX = 1,
                    PKG = ""
                };
                db.Vols.Add(v1);
                db.SaveChanges();
                
                Console.WriteLine(v1.CIE);
                Bagage b1 = new Bagage
                {
                    VOLID = 1,
                    CODE_IATA = "AZERTY"
                };
                db.Bagages.Add(b1);
                db.SaveChanges();
                
                var bag = db.Bagages.First();
                Console.WriteLine(bag.CODE_IATA);
                // Update
                bag.CODE_IATA = "TREZA";
                bag.SSUR = "AZE";
                db.SaveChanges();
                var bag1 = db.Bagages.First();
                Console.WriteLine(bag1.CODE_IATA);
                // Delete
                db.Remove(bag);
                db.SaveChanges();
                



            }


        }
    }
}
