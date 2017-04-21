namespace StJudesStudentInfo.Migrations
{
    using StJudesStudentInfo.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<StJudesStudentInfo.DAL.SchoolContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(StJudesStudentInfo.DAL.SchoolContext context)
        {
            var students = new List<Students>
            {
                new Students{FirstName="Rida",LastName="Ishfani",EnrollmentDate=DateTime.Parse("2005-09-01")},
                new Students{FirstName="Nida",LastName="Baig",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Students{FirstName="Rehnuma",LastName="Alex",EnrollmentDate=DateTime.Parse("2003-09-01")},
                new Students{FirstName="Perwaize",LastName="Musharraf",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Students{FirstName="Mehreen",LastName="Tazza",EnrollmentDate=DateTime.Parse("2002-09-01")},
                new Students{FirstName="Sana",LastName="Chikni",EnrollmentDate=DateTime.Parse("2001-09-01")},
            };
            students.ForEach(s => context.Students.AddOrUpdate(s));
            context.SaveChanges();

            var courses = new List<Course>
            {
                new Course{CourseID=1050,Title="Chemistry",Credits=3,},
                new Course{CourseID=4022,Title="Microeconomics",Credits=3,},
                new Course{CourseID=4041,Title="Macroeconomics",Credits=3,},
                new Course{CourseID=1045,Title="Calculus",Credits=4,},
                new Course{CourseID=3141,Title="Trigonometry",Credits=4,},
                new Course{CourseID=2021,Title="Composition",Credits=3,},
                new Course{CourseID=2042,Title="Literature",Credits=4,}
            };
            courses.ForEach(c => context.Course.AddOrUpdate(c));
            context.SaveChanges();

            var enrollments = new List<Enrollment>
            {
                new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
                new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
                new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
                new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
                new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
                new Enrollment{StudentID=3,CourseID=1050},
                new Enrollment{StudentID=4,CourseID=1050,},
                new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
                new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
                new Enrollment{StudentID=6,CourseID=3141,Grade=Grade.A}
            };
            enrollments.ForEach(e => context.Enrollment.AddOrUpdate(e));
            context.SaveChanges();
        }
    }
}
