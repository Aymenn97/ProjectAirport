using System;
using System.Collections.Generic;
using System.Text;

namespace A.MyAirport.EF
{
    public class Vol
    {
        public Vol()
        {
            this.Bagages = new HashSet<Bagage>();
        }
        public int VOLID { get; set; }
        public string CIE { get; set; }
        public string LIG { get; set; }
        
        public DateTime DHC { get; set; }
        public string PKG { get; set; }
        public string IMM { get; set; }
        public short PAX { get; set; }
        public string DES { get; set; }
        public virtual ICollection<Bagage> Bagages { get; set; }
    }
}
