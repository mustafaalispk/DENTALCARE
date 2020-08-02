using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare.Domain
{
    // Vi behöver inte skapa instanser/objekt av den klassen
    abstract class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public string PhoneNumber { get; }
        public string Email { get; }

        public Person(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            PhoneNumber = phoneNumber;
            Email = email;
        }
    }

}
