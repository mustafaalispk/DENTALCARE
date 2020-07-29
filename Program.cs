using System;
using static System.Console;

namespace DentalCare
{
    class Program
    {
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
                        
                        // Vi skriver true därför att vi vill inte att tecknad skriver upp på skärmen.
                        keyPressed = ReadKey(true);

                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:

                        break;

                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:

                        shouldNotExit = false;

                        break;


                }

            }
        }
    }
}
