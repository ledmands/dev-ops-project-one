using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOpsProjectOne.Data;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Pages.Parts_Plants
{
    public class IndexModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public IndexModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        public IList<Part_Plant> Part_Plant { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Part_Plant != null)
            {
                Part_Plant = await _context.Part_Plant.ToListAsync();
            }
        }
    }
}
