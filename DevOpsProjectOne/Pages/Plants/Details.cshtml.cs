using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using DevOpsProjectOne.Data;
using DevOpsProjectOne.Models;

namespace DevOpsProjectOne.Pages.Plants
{
    public class DetailsModel : PageModel
    {
        private readonly DevOpsProjectOne.Data.CompanyContext _context;

        public DetailsModel(DevOpsProjectOne.Data.CompanyContext context)
        {
            _context = context;
        }

      public Plant Plant { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Plant == null)
            {
                return NotFound();
            }

            var plant = await _context.Plant.FirstOrDefaultAsync(m => m.Plant_id == id);
            if (plant == null)
            {
                return NotFound();
            }
            else 
            {
                Plant = plant;
            }
            return Page();
        }
    }
}
