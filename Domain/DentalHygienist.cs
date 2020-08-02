using System;
using System.Collections.Generic;
using System.Text;

namespace DentalCare.Domain
{
    class DentalHygienist : Employee
    {
        public DentalHygienist(string firstName, string lastName, string socialSecurityNumber, string phoneNumber, string email, string id, ushort salary)
            : base(firstName, lastName, socialSecurityNumber, phoneNumber, email, id, salary)
        {
        }
        // ToString är nånting som vi har på objektet i sig. 
        // Vi kan inte se Tostring men den ligger på objektet.
        // Det betyder att vi ärver från nånting som heter objekt.
        public override string ToString()
        {
            return $"{FirstName} {LastName}, DentalHygenist";
        }
    }
}
