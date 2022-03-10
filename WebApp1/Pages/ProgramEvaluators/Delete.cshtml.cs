#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages.ProgramEvaluators
{
    public class DeleteModel : PageModel
    {
        private readonly WebApp1.Data.ApbetProjectContext _context;

        public DeleteModel(WebApp1.Data.ApbetProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProgramEvaluator ProgramEvaluator { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProgramEvaluator = await _context.ProgramEvaluator.FirstOrDefaultAsync(m => m.ProgramEvaluatorID == id);

            if (ProgramEvaluator == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProgramEvaluator = await _context.ProgramEvaluator.FindAsync(id);

            if (ProgramEvaluator != null)
            {
                _context.ProgramEvaluator.Remove(ProgramEvaluator);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
