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
    public class DeleteModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public DeleteModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Vendor Vendor { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }

            var vendor = await _context.Vendor.FirstOrDefaultAsync(m => m.Vendor_id == id);

            if (vendor == null)
            {
                return NotFound();
            }
            else 
            {
                Vendor = vendor;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Vendor == null)
            {
                return NotFound();
            }
            var vendor = await _context.Vendor.FindAsync(id);

            if (vendor != null)
            {
                Vendor = vendor;
                _context.Vendor.Remove(Vendor);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
