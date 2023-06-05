using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Final_Model
{
    public class Person
    {
        public Person() { }

        public Person(string fname, string lname, string email)
        {
            //this.age = age;
            this.FirstName = fname;
            this.LastName = lname;
            this.Email = email;
        }

        // this constructor will take the data from the Chinook Db (for demo purposes)
        public Person(string fn, string ln, DateTime dt, string remarks, string username, string pw)
        {
            this.UserName = username;
            this.Password = pw;
            this.FirstName = fn;
            this.LastName = ln;
            this.LastOrderDate = dt;
            this.Remarks = remarks;
        }


        public Person(Guid id, string fn, string ln, DateTime dt, string remarks, string username, string pw)
        {
            this.CustomerId = id;
            this.FirstName = fn;
            this.LastName = ln;
            this.LastOrderDate = dt;
            this.Remarks = remarks;
            this.UserName = username;
            this.Password = pw;
        }

        public Guid CustomerId { get; set; } = Guid.NewGuid();
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string LastName { get; set; }// this is a "property"
        public string Remarks { get; set; }
        public DateTime LastOrderDate { get; set; }
         [Range(0, 100)]
        
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Got an error")]// The part before the @ restricts to characters commonly used in emails. The part after the @ restricts to characters allowed in domain names.
        public string Email { get; set; }

    }

}