using System;

namespace DentalCare.Domain
{
    class Booking
    {
        public Booking(string firstName, string lastName, string socialSecuirtyNumber, string phoneNumber, string email, string reason, string employee, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            SocialSecuirtyNumber = socialSecuirtyNumber;
            PhoneNumber = phoneNumber;
            Email = email;
            Reason = reason;
            Employee = employee;
            Date = date;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string SocialSecuirtyNumber { get; }
        public string PhoneNumber { get; }
        public string Email { get; }
        public string Reason { get; }
        public string Employee { get; }
        public DateTime Date { get; }
    }
}
