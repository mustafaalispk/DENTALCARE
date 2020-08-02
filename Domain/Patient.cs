﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare.Domain
{
    class Patient
    {
        public Patient(string firstName, string lastName, string socialSecurityNumber, string phoneNumber,string email)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecurityNumber = socialSecurityNumber;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecurityNumber { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
    }
}
