#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApp1.Models;

namespace WebApp1.Data
{
    public class ApbetProjectContext : DbContext
    {
        public ApbetProjectContext (DbContextOptions<ApbetProjectContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp1.Models.Instructor> Instructor { get; set; }

        public DbSet<WebApp1.Models.ProgramAdmin> ProgramAdmin { get; set; }

        public DbSet<WebApp1.Models.ProgramEvaluator> ProgramEvaluator { get; set; }

        public DbSet<WebApp1.Models.SystemAdmin> SystemAdmin { get; set; }

        #region snippet2
        public async virtual Task AddProgramAdminAsync(WebApp1.Models.ProgramAdmin programAdmin)
        {
            await ProgramAdmin.AddAsync(programAdmin);
            await SaveChangesAsync();
        }
        #endregion

        public async virtual Task AddInstructorAsync(WebApp1.Models.Instructor Instructor)
        {
            await Instructor.AddAsync(Instructor);
            await SaveChangesAsync();
        }
    }
}
