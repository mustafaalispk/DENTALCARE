using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare.Domain
{
    class Dentist : Employee
    {
        public Dentist(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email, string id, ushort salary) 
            : base(firstName, lastName, socialSecurityNumber, phoneNumber, email, id, salary)
        {
        }
        public override string ToString()
        {
            return $"{FirstName} {LastName}, TandLäkare";
        }
    }
}
