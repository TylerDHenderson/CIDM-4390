using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 
using Microsoft.AspNetCore.Authorization;


namespace WebApp1.Models
{
 
    public class SystemAdmin
    {
        
        public int SystemAdminID {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}



    public SystemAdminStatus Status { get; set; }
    }
   //what role they will have
    public enum SystemAdminStatus
    {
        Add,
        Edit,
        Delete
    }


}