using A.MyAirport.EF;
using Myairportgraph;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Myairportgraph
{
    public class AirportQuery : ObjectGraphType
    {
        public AirportQuery(MyAirportContext db)
        {
            Field<ListGraphType<BagageType>>(
              "bagegs",
              resolve: Context => db.Bagages.ToList());
            //Field<ListGraphType<BagageType>>(
               // "bagage",
               // arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "BagageId" }),
               // resolve: context => db.Bagages.First(b => b.BAGAGEID == context.GetArgument<int>("BagageId")));
            }
    }
}
