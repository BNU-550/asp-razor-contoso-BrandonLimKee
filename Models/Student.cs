using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_RazorContoso.Models
{
    public class Student : Person
    {
        public int StudentID { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20, ErrorMessage = "Last Name cannot be longer then 20 characters")]
        public string LastName { get; set; }
        
        [Column("FirstName")]

        [DisplayName("First Name"), Required, StringLength(20, ErrorMessage ="First Name cannot be longer then 20 characters")]
        public string FirstName { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]

        [DisplayName("Enrol Date"), DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }

        // Relationships or navigation properties
        public virtual ICollection<Enrollment> Enrollments { get; set; }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}
