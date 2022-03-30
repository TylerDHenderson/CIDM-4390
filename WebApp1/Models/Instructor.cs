using System.ComponentModel.DataAnnotations;
using System.Collections.Generic; 
using Microsoft.AspNetCore.Authorization;

namespace WebApp1.Models
{
    public class Instructor
    {
        public int InstructorID {get;set;}
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int CourseID {get;set;}

        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}


        public InstructorStatus Status { get; set; }
    }
    //what role they will have
    public enum InstructorStatus
    {
        Add,
        Edit
        
    }
}