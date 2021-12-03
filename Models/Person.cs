using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_RazorContoso.Models
{
    public class Person
    {
        public int PersonId { get; set; }

        [StringLength(256)]
        public string UserId { get; set; }

        [DisplayName("Last Name"), Required, StringLength(20)]
        public string LastName { get; set; }

        [DisplayName("First Name"), Required, StringLength(20)]
        public string FirstName { get; set; }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }


    }
}
