using ASP_RazorContoso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Data
{
    public class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            AddStudents(context);

            AddCourses(context);

            AddEnrollments(context);

            //AddModules(context);
        }

        private static void AddStudents(ApplicationDbContext context)
        {
            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
                new Student{FirstName="Shannen ",LastName="Bateman",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new Student{FirstName="Komal ",LastName="Fry",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Samual ",LastName="Sears",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Lauren ",LastName="Leon",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Estelle ",LastName="Bender",EnrollmentDate=DateTime.Parse("2017-09-01")},
                new Student{FirstName="Scarlette ",LastName="Nicholls",EnrollmentDate=DateTime.Parse("2016-09-01")},
                new Student{FirstName="Lina ",LastName="Jarvis",EnrollmentDate=DateTime.Parse("2018-09-01")},
                new Student{FirstName="Kenan ",LastName="Noel",EnrollmentDate=DateTime.Parse("2019-09-01")}
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        private static void AddCourses(ApplicationDbContext context)
        {
            if (context.modules.Any())
            {
                return;   // DB has been seeded
            }

            Module co550 = new Module
            {
                ModuleID = "CO550",
                Title = "Web Applications",
            };

            Module co588 = new Module
            {
                ModuleID = "CO558",
                Title = "Database Design",
            };

            Module co567 = new Module
            {
                ModuleID = "CO567",
                Title = "OO Systems Development",
            };

            Module co566 = new Module
            {
                ModuleID = "CO566",
                Title = "Mobile Systems",
            };

            var modules = new Module[]
            {
                co550, co566, co567, co588
            };

            context.modules.AddRange(modules);
            context.SaveChanges(true);

            if (context.Courses.Any())
            {
                return;   // DB has been seeded
            }

            var courses = new Course[]
            {
                new Course{CourseID="BT1CTG1",Title="Computing",
                Modules = new List<Module>{co550,co566,co567,co588} },
                new Course{CourseID="BT1CWD1",Title="Computing and Web",
                Modules = new List<Module>{co550,co566,co567,co588} },
                new Course{CourseID="BB1DSC1",Title="Data Science"},
                new Course{CourseID="BT1SFT1",Title="Software Engineering"},
                new Course{CourseID="BB1ARI1",Title="Artifical Intelligence"},
                new Course{CourseID="MT1CYS1",Title="Cyber Security"},
                new Course{CourseID="BT1GDV1",Title="Games Development"}
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }
        private static void AddEnrollments(ApplicationDbContext context)
        {
            if (context.Enrollments.Any())
            {
                return;   // DB has been seeded
            }

            var enrollments = new Enrollment[]
            {
                new Enrollment{StudentID=1,CourseID="BT1CTG1",Grade=Grades.A},
                new Enrollment{StudentID=2,CourseID="BT1CWD1",Grade=Grades.B},
                new Enrollment{StudentID=3,CourseID="BB1DSC1",},
                new Enrollment{StudentID=4,CourseID="BT1SFT1",Grade=Grades.F},
                new Enrollment{StudentID=5,CourseID="BB1ARI1",Grade=Grades.C},
                new Enrollment{StudentID=6,CourseID="MT1CYS1"},
                new Enrollment{StudentID=7,CourseID="BT1GDV1",Grade=Grades.A},

            };

            context.Enrollments.AddRange(enrollments);
            context.SaveChanges();
        }
        //private static void AddModules(ApplicationDbContext context)
        //{
        //    if (context.modules.Any())
        //    {
        //        return;   // DB has been seeded
        //    }

        //    var modules = new Module[]
        //    {
        //        new Module{ModuleID = "CO550", Title="Web Applications"},
        //        new Module{ModuleID = "CO558", Title="Database Design"},
        //        new Module{ModuleID = "CO567", Title="OO Systems Development"},
        //        new Module{ModuleID = "CO566", Title="Mobile Systems"},
        //    };

        //    context.modules.AddRange(modules);
        //    context.SaveChanges(true);
        //}
    }
}
