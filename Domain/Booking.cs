using System;

namespace DentalCare.Domain
{
    class Booking
    {
        // Vi kommer behöva/associera Booking med Patient.Vi skriver Patient patient för att vi vill ha en reference till patient.
        // Det har vi gjort här, vi drog ut allting hade från Patient och la in i den klassen Patient och sen
        // skapar istället en reference till patient.
        public Booking(Patient patient,string reason, string employee, DateTime date)
        {
            Patient = patient;
            Reason = reason;
            Employee = employee;
            Date = date;
        }

        public Patient Patient { get; }
        public string Reason { get; }
        public string Employee { get; }
        public DateTime Date { get; }
    }
}
