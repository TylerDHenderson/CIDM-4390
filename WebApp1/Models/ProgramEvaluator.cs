using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 
using Microsoft.AspNetCore.Authorization;

namespace WebApp1.Models
{
    public class ProgramEvaluator
    {
        public int ProgramEvaluatorID {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}

    }

    
}