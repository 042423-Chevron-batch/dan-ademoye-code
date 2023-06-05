using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Final_Model
{
    public class RegDto
    {
        public RegDto() { }

        public RegDto(string fname, string lname, string email)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
        }

        public RegDto(Guid id, string fn, string ln, DateTime dt, string remarks, string username, string pw)
        {
            //this.CustomerId = id;
            this.FirstName = fn;
            this.LastName = ln;
            this.LastOrderDate = dt;
            this.Remarks = remarks;
            this.UserName = username;
            this.Password = pw;
        }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The {0} length must be between {2} and {1}.")]
        public string UserName { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The {0} length must be between {2} and {1}.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "The {0} length must be between {2} and {1}.")]
        public string LastName { get; set; }// this is a "property"

        public string Remarks { get; set; }

        public DateTime LastOrderDate { get; set; }

        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Got an error")]// The part before the @ restricts to characters commonly used in emails. The part after the @ restricts to characters allowed in domain names.
        public string Email { get; set; }

    }
}