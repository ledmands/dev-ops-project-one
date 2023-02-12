using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevOpsProjectOne.Data;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Pages.Parts_Plants
{
    public class EditModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public EditModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Part_Plant Part_Plant { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Part_Plant == null)
            {
                return NotFound();
            }

            var part_plant =  await _context.Part_Plant.FirstOrDefaultAsync(m => m.Plant_id == id);
            if (part_plant == null)
            {
                return NotFound();
            }
            Part_Plant = part_plant;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Part_Plant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Part_PlantExists(Part_Plant.Plant_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool Part_PlantExists(int id)
        {
          return _context.Part_Plant.Any(e => e.Plant_id == id);
        }
    }
}
