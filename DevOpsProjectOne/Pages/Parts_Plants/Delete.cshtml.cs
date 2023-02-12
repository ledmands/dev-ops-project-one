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
    public class DeleteModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public DeleteModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Part_Plant Part_Plant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Part_Plant == null)
            {
                return NotFound();
            }

            var part_plant = await _context.Part_Plant.FirstOrDefaultAsync(m => m.Plant_id == id);

            if (part_plant == null)
            {
                return NotFound();
            }
            else 
            {
                Part_Plant = part_plant;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Part_Plant == null)
            {
                return NotFound();
            }
            var part_plant = await _context.Part_Plant.FindAsync(id);

            if (part_plant != null)
            {
                Part_Plant = part_plant;
                _context.Part_Plant.Remove(Part_Plant);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
