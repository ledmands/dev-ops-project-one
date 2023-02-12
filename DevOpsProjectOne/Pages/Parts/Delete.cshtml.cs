using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOpsProjectOne.Data;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Pages.Parts
{
    public class DeleteModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public DeleteModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Part Part { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Part == null)
            {
                return NotFound();
            }

            var part = await _context.Part.FirstOrDefaultAsync(m => m.Part_id == id);

            if (part == null)
            {
                return NotFound();
            }
            else 
            {
                Part = part;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Part == null)
            {
                return NotFound();
            }
            var part = await _context.Part.FindAsync(id);

            if (part != null)
            {
                Part = part;
                _context.Part.Remove(Part);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
