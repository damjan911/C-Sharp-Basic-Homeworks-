using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string GetPersonDetails()
        {
            return $"Your Fullname is {FirstName} {LastName} and you are {Age} years old! ";
        }
    }
}
