#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages.ProgramAdmins
{
    public class EditModel : PageModel
    {
        private readonly WebApp1.Data.ApbetProjectContext _context;

        public EditModel(WebApp1.Data.ApbetProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProgramAdmin ProgramAdmin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProgramAdmin = await _context.ProgramAdmin.FirstOrDefaultAsync(m => m.ProgramAdminID == id);

            if (ProgramAdmin == null)
            {
                return NotFound();
            }
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

            _context.Attach(ProgramAdmin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProgramAdminExists(ProgramAdmin.ProgramAdminID))
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

        private bool ProgramAdminExists(int id)
        {
            return _context.ProgramAdmin.Any(e => e.ProgramAdminID == id);
        }
    }
}
