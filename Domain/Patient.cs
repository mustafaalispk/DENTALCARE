using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare.Domain
{
    class Patient : Person
    {
        public Patient(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email)
            : base(firstName,lastName,socialSecurityNumber,phoneNumber,email)
        {

        }



    }
}
