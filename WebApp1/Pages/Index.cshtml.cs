#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;        // Required using directives for Data Validation
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp1.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
        // Add Data Validation Rules
        [Display(Name = "First Name")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string FirstName {get; set;}

        [BindProperty]
        public string LastName {get; set;}

        [BindProperty]
        // Add Data Validation Rules
        [Display(Name = "Course")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string CouseName {get; set;}

        [BindProperty]
        public string Semester {get; set;}

        [BindProperty]
        public int Year {get; set;}

        [BindProperty]
        public string CourseCoordinator {get;set;}
        [BindProperty]
        public string CatalogDescription {get;set;}
        [BindProperty]
        public string GradeDistrubution {get;set;}
        [BindProperty]
        public string ModificationsCourse {get;set;}
        [BindProperty]
        public string StudentFeedback {get;set;}
        [BindProperty]
        public string Reflection {get;set;}
        [BindProperty]
        public string CourseImprovement {get;set;}



        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
                
        }

        public void OnPost()
        {
            // Print out FirstName and LastName just like any other property.
            _logger.LogWarning($"On Post {FirstName} {LastName}");
        }
    }



