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

namespace WebApp1.Pages.SystemAdmins
{
    public class DetailsModel : PageModel
    {
        private readonly WebApp1.Data.ApbetProjectContext _context;

        public DetailsModel(WebApp1.Data.ApbetProjectContext context)
        {
            _context = context;
        }

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
    }
}
