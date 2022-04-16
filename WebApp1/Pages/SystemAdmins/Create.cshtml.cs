#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApp1.Data;
using WebApp1.Models;

namespace WebApp1.Pages.SystemAdmins
{
    public class CreateModel : PageModel
    {
        private readonly WebApp1.Data.ApbetProjectContext _context;

        public CreateModel(WebApp1.Data.ApbetProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public SystemAdmin SystemAdmin { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.SystemAdmin.Add(SystemAdmin);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
