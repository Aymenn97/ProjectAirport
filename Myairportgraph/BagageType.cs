using System;
using GraphQL.Types;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using A.MyAirport.EF;


namespace Myairportgraph
{
    public class BagageType: ObjectGraphType<Bagage>
    {
        public BagageType()
        {
            Field(x => x.BAGAGEID);
            Field(x => x.CLASSE);
            Field(x => x.CODE_IATA);
            Field(x => x.DATA_CREATION);
            Field(x => x.DESTINATION);
            Field(x => x.ESCALE);
            Field(x => x.PRIORITAIRE);
            Field(x => x.STA);
            Field(x => x.SSUR);
            Field(x => x.VOLID);
        }
    }
}
