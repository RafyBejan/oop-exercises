using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop_exercises
{
    internal class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public DateTime DateofBirth { get; set; }
        public int Age
        { get
            {
                return DateTime.Now.Year - DataOfBirth.Year;

            }
        }

            
            

    
}
