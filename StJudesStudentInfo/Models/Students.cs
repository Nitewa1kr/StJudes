using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StJudesStudentInfo.Models
{
    public class Students
    {
        [Key]
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }
    }
}