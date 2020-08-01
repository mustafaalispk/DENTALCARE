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

        static void Main(string[] args)
        {
           
            bool shouldNotExit = true;

            while (shouldNotExit)
            {
                WriteLine("1. Skapa bokning");
                WriteLine("2. List bokning");
                WriteLine("3. Avsluta");

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
                                // create booking...

                                CreateBooking(
                                    firstName,
                                    lastName,
                                    socialSecuirtyNumber,
                                    phoneNumber,
                                    email,
                                    reason,
                                    employee,
                                    date);

                                isBooked = true;

                            }   
                            

                        } while (!isBooked);

                        Clear();

                        WriteLine("Booking skappad");

                        Thread.Sleep(2000);

                        Clear();

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        ListBooking();

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        shouldNotExit = false;

                        break;


                }

            }
        }

        private static void ListBooking()
        {
            WriteLine("Patient      Anledning         Tid");
            WriteLine("--------------------------------------");

            foreach (Booking booking in bookingList)
            {
                WriteLine($"{booking.FirstName} {booking.LastName}, {booking.SocialSecuirtyNumber}          {booking.Reason}  {booking.Date}");
            }

            ReadKey(true);

            Clear();
        }

        private static void CreateBooking(string firstName, string lastName, string socialSecuirtyNumber, string phoneNumber, string email, string reason, string employee, DateTime date)
        {
            Booking booking = new Booking(firstName, lastName, socialSecuirtyNumber, phoneNumber, email,reason,employee, date);

            bookingList.Add(booking);

        }
    }
}
