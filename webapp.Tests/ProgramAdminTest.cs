using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using WebApp1.Data;
using WebApp1.Models;

namespace webapp.Tests;

public class ProgramAdminTest
{
        [Fact]
        public async Task AddProgramAdminAsync_ProgramAdminIsAdded()
        {
            using (var db = new ApbetProjectContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;
                var expectedProgramAdmin = new ProgramAdmin() 
                { 
                    ProgramAdminID = recId, 
                    FirstName = "Tester",
                    LastName = "Test",
                    Email = "Tester.Test12@gmail.com",
                };

                // Act
                await db.AddProgramAdminAsync(expectedProgramAdmin);

                // Assert
                var actualProgramAdmin = await db.FindAsync<ProgramAdmin>(recId);
                Assert.Equal(expectedProgramAdmin, actualProgramAdmin);
            }
        }

        [Fact]
        public async Task SubmitForm()
        {
            
            using (var db = new ApbetProjectContext(Utilities.TestDbContextOptions()))
            {
                var IntID = 12;
                var expectedFormSubmission = new Instructor()
                {
                    InstructorID = IntID,
                    FirstName = "Tim",
                    LastName = "Hope",
                    Email = "Tim.TimHope@gmail.com",
                    //FormSubmission = False
                };

                await db.AddFormSubmissionAsync(expectedFormSubmission);

                var actualFormSubmission = await db.FindAsync<Instructor>(IntID);
                //Assert.False();
            }
        }

        [Fact]
        public async Task InstructorAuthenticated()
        {
            using (var db = new ApbetProjectContext(Utilities.TestDbContextOptions()))
            {
                var InstrucID =11;
                var expectedInstructor = new Instructor()
                {
                    InstructorID = InstrucID,
                    FirstName = "Testing",
                    LastName = "StillTesting",
                    Email = "test.testingstill@gmail.com",

                    
                };

                await db.AddInstructorAsync(expectedInstructor);
                //Assert.

                var actualInstructor = await db.FindAsync<Instructor>(InstrucID);
                Assert.Equal(expectedInstructor, actualInstructor);
            }
        }

}