using DentalCare.Domain;
using System;
using System.Collections.Generic;
using System.Threading;
using static System.Console;

namespace DentalCare
{
    class Program
    {
        static List<Booking> bookingList = new List<Booking>();

        static List<Patient> patientList = new List<Patient>();

        static void Main(string[] args)
        {
           
            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                Clear();

                WriteLine("1. Skapa bokning");
                WriteLine("2. List bokning");
                WriteLine("3. Register kund");
                WriteLine("4. Avsluta");

                ConsoleKeyInfo keyPressed = ReadKey(true);

                Clear();

                switch (keyPressed.Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:

                        bool isBooked = false;

                        do
                        {
                            Clear();

                            Write("Personnummer: ");
                            string socialSecuirtyNumber = ReadLine();

                            Write("Anledning: ");
                            string reason = ReadLine();


                            Write("Utförs av: ");
                            string employee = ReadLine();


                            Write("Datum (yyyy-mm-dd hh:mm): ");
                            DateTime date = DateTime.Parse(ReadLine());

                            WriteLine("Är dettta rätt ? (J)a eller (N)ej");

                            bool validKeyPressed;

                            do
                            {
                                // Vi skriver true därför att vi vill inte att tecknad skriver upp på skärmen.
                                keyPressed = ReadKey(true);

                                validKeyPressed = keyPressed.Key == ConsoleKey.J ||
                                    keyPressed.Key == ConsoleKey.N;

                            } 
                            while (!validKeyPressed);
                               
                            if (keyPressed.Key == ConsoleKey.J)
                            {
                                // Här hitta vi en patient om vi hittar ej patient då visar den "kund ej registrerad"
                                // annars kommer den lägga in en ny booking med existerande patient.

                                Patient patient = FindPatientBySocialSecurityNumber(socialSecuirtyNumber);
                                
                                if (patient == null)
                                {
                                    Clear();

                                    WriteLine("Kund ej registrerad");

                                    Thread.Sleep(2000);

                                }
                                else
                                {
                                    // create booking...
                                    CreateBooking(
                                        patient,
                                        reason,
                                        employee,
                                        date);

                                    Clear();

                                    WriteLine("Booking skappad");

                                    Thread.Sleep(2000);

                                    Clear();
                                    
                                }

                                isBooked = true;


                            }   
                            

                        } while (!isBooked);

                       

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        ListBooking();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        bool isValidInput = false;
                        do
                        {
                            Clear();

                            Write("Förnamn: ");
                            string firstName = ReadLine();


                            Write("Efternam: ");
                            string lastName = ReadLine();


                            Write("Personnummer: ");
                            string socialSecuirtyNumber = ReadLine();


                            Write("Telefonummer: ");
                            string phoneNumber = ReadLine();


                            Write("E-mail: ");
                            string email = ReadLine();

                            WriteLine("Är dettta rätt ? (J)a eller (N)ej");

                            bool validKeyPressed;

                            do
                            {
                                // Vi skriver true därför att vi vill inte att tecknad skriver upp på skärmen.
                                keyPressed = ReadKey(true);

                                validKeyPressed = keyPressed.Key == ConsoleKey.J ||
                                    keyPressed.Key == ConsoleKey.N;

                            }
                            while (!validKeyPressed);

                            if (keyPressed.Key == ConsoleKey.J)
                            {
                                // Den metoden kommer retunera en patient.
                                Patient patient = FindPatientBySocialSecurityNumber(socialSecuirtyNumber);

                                // Om ny patient finns inte i register redan då kommer vi skapa och lägga in i listan.
                                if (patient == null)
                                {
                                    // Creating new patient
                                    patient = new Patient(firstName, lastName, socialSecuirtyNumber, phoneNumber, email);
                                   
                                    patientList.Add(patient);

                                    Clear();

                                    WriteLine("Kund registrerad");

                                    Thread.Sleep(2000);

                                    
                                }
                                else
                                {
                                    Clear();

                                    WriteLine("Patient redan registrerad");

                                    Thread.Sleep(2000);
                                }
                                isValidInput = true;

                            }

                        } while (!isValidInput);

                        break;

                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:

                        shouldNotExit = false;

                        break;


                }

            }
        }

        private static Patient FindPatientBySocialSecurityNumber(string socialSecuirtyNumber)
        {
            // För att hitta en patient då kommer vi använda foreach()

            foreach (Patient patient in patientList)
            {
                if (patient.SocialSecurityNumber == socialSecuirtyNumber)
                {
                    return patient;
                }
            }

            return null;
        }

        private static void ListBooking()
        {
            WriteLine("Patient      Anledning         Tid");
            WriteLine("--------------------------------------");

            foreach (Booking booking in bookingList)
            {
                WriteLine($"{booking.Patient.FirstName} {booking.Patient.LastName}, {booking.Patient.SocialSecurityNumber}          {booking.Reason}  {booking.Date}");
            }

            ReadKey(true);

            Clear();
        }

        private static void CreateBooking(Patient patient, string reason, string employee, DateTime date)
        {
            Booking booking = new Booking(patient,reason,employee, date);

            bookingList.Add(booking);

        }
    }
}
