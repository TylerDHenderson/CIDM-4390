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
    public class IndexModel : PageModel
    {
        private readonly WebApp1.Data.ApbetProjectContext _context;

        public IndexModel(WebApp1.Data.ApbetProjectContext context)
        {
            _context = context;
        }

        public IList<SystemAdmin> SystemAdmin { get;set; }

        public async Task OnGetAsync()
        {
            SystemAdmin = await _context.SystemAdmin.ToListAsync();
        }
    }
}
