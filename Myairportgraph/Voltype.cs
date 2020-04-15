using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.MyAirport.EF;

namespace Myairportgraph
{
    public class Voltype : ObjectGraphType<Vol>
    {
        public Voltype()
        {
            Field(x => x.CIE);
            Field(x => x.LIG);
            Field(x => x.DHC);
            Field(x => x.PKG);
            Field(x => x.IMM);
            Field(x => x.PAX);
            Field(x => x.DES);
            Field(x => x.VOLID);

        }
    }
}
