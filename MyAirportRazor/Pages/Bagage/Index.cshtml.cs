using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using A.MyAirport.EF;

namespace MyAirportRazor
{
    public class IndexModelBagage : PageModel
    {
        private readonly A.MyAirport.EF.MyAirportContext _context;

        public IndexModelBagage(A.MyAirport.EF.MyAirportContext context)
        {
            _context = context;
        }

        public IList<Bagage> Bagage { get;set; }

        public async Task OnGetAsync()
        {
            Bagage = await _context.Bagages.ToListAsync();
        }
    }
}
