using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SingleyLinkedListNamespace
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string fname, string lname)
        {
            this.Fname = fname;
            this.Lname = lname;

        }
        public string Fname { get; set; } = "";
        public string Lname { get; set; } = "";



    }
}