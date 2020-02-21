using System;
using System.Collections.Generic;
using System.Text;

namespace A.MyAirport.EF
{
    class Bagage
    {
        public int ID_BAGAGE { get; set; }
        public int ID_VOL { get; set; }
        public char CODE_IATA { get; set; }
        public int DATA_CREATION { get; set; }
        public List<Post> Posts { get; set; }
    }
}
