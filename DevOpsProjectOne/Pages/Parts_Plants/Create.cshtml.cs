using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using DevOpsProjectOne.Data;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Pages.Parts_Plants
{
    public class CreateModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public CreateModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Part_Plant Part_Plant { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Part_Plant.Add(Part_Plant);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
