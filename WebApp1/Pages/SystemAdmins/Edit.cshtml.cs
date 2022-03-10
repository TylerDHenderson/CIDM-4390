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

namespace WebApp1.Pages.SystemAdmins
{
    public class EditModel : PageModel
    {
        private readonly WebApp1.Data.ApbetProjectContext _context;

        public EditModel(WebApp1.Data.ApbetProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public SystemAdmin SystemAdmin { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            SystemAdmin = await _context.SystemAdmin.FirstOrDefaultAsync(m => m.SystemAdminID == id);

            if (SystemAdmin == null)
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

            _context.Attach(SystemAdmin).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SystemAdminExists(SystemAdmin.SystemAdminID))
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

        private bool SystemAdminExists(int id)
        {
            return _context.SystemAdmin.Any(e => e.SystemAdminID == id);
        }
    }
}
