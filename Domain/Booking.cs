using System;

namespace DentalCare.Domain
{
    class Booking 
    {
        // Vi kommer behöva/associera Booking med Patient.Vi skriver Patient patient för att vi vill ha en reference till patient.
        // Det har vi gjort här, vi drog ut allting hade från Patient och la in i den klassen Booking och sen
        // skapar istället en reference till patient.
        public Booking(Patient patient,string reason, Employee employee, DateTime date)
        {
            Patient = patient;
            Employee = employee;
            Reason = reason;            
            Date = date;
        }

        public Patient Patient { get; }
        public Employee Employee { get; }
        public string Reason { get; }        
        public DateTime Date { get; }
    }
}
