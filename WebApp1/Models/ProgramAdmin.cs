using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 
using Microsoft.AspNetCore.Authorization;

namespace WebApp1.Models
{
    public class ProgramAdmin
    {
        public int ProgramAdminID {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}

        public ProgramAdminStatus Status { get; set; }
    }
   //what role they will have
    public enum ProgramAdminStatus
    {
        Add

    }
}