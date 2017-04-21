using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StJudesStudentInfo.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        [Key]
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }
        [ForeignKey("CourseID")]
        public virtual Course Course { get; set; }
        [ForeignKey("StudentID")]
        public virtual Students Students { get; set; }

    }
}