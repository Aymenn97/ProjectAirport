using System;
using System.Collections.Generic;
using System.Text;

namespace A.MyAirport.EF
{
    class Bagage
    {
        public int BAGAGEID{ get; set; }
        public int VOLID { get; set; }
        public char CODE_IATA { get; set; }
        public int DATA_CREATION { get; set; }
        public char CLASSE{ get; set; }
        public Boolean PRIORITAIRE { get; set; }
        public char STA { get; set; }
        public char SSUR { get; set; }
        public char DESTINATION { get; set; }
        public char ESCALE { get; set; }
      
    }
}
