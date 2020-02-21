using System;
using System.Collections.Generic;
using System.Text;

namespace A.MyAirport.EF
{
    public class Vol
    {
        public int VOLID { get; set; }
        public int CIE { get; set; }
        public string LIG { get; set; }
        public short JEX { get; set; }
        public DateTime DHC { get; set; }
        public string PKG { get; set; }
        public string IMM { get; set; }
        public short PAX { get; set; }
        public string DES { get; set; }
    }
}
