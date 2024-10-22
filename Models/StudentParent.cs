namespace CollegeManagementSystem.Models;

public record class StudentParent
{
    public int StudentParentId { get; set; }

    public int StudentId { get; set; }
    public int CourseId { get; set; }
  
/*     public int EnrollementId { get; set; } */
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
/* 
    public Enrollment? Enrollment { get; set; } */
    public Student? Student { get; set; }
    public Course? Course { get; set; }
}
