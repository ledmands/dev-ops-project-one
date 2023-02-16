using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOpsProjectOne.Data;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Pages.Vendors
{
    public class IndexModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public IndexModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        public IList<Vendor> Vendor { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Vendor != null)
            {
                Vendor = await _context.Vendor.ToListAsync();
            }
        }
    }
}
