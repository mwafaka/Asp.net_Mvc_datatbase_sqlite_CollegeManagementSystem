using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CollegeManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime EnrollmentDate { get; set; }
/* We add this line  new List<Enrollment>(); to prevent the error while creating a new instance of Student  */
        public ICollection<Enrollment> Enrollments { get; set; } = new List<Enrollment>();
    }
}
