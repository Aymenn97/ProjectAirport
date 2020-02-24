using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace A.MyAirport.EF
{
    public class Bagage
    {
        
        public int BAGAGEID{ get; set; }
        //[ForeignKey("VOLID")]
        public int? VOLID { get; set; }
        public virtual Vol Vol { get; set; }
        public string CODE_IATA { get; set; }
        public DateTime DATA_CREATION { get; set; }
        public string CLASSE{ get; set; }
        public bool PRIORITAIRE { get; set; }
        public string STA { get; set; }
        public string SSUR { get; set; }
        public string DESTINATION { get; set; }
        public string ESCALE { get; set; }
      
    }
}
