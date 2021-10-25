using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib ees- ja perekonnanime
            //programm kontrollib pikkust eraldi
            //programm kuvab kumb neist on pikem, ees- või perekonnanimi



            Console.WriteLine("Sisesta eesnimi: ");

            string FirstName = Console.ReadLine();

            int FirstNameLength = FirstName.Length;


            Console.WriteLine("Sisesta perekonnanimi: ");

            string LastName = Console.ReadLine();

            int LastNameLength = LastName.Length;


            if (FirstNameLength < LastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on lühem kui perekonnanimi.");
            }

            else if (FirstNameLength > LastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikem kui sinu perekonnanimi.");
            }

            else 
            {
                    Console.WriteLine("Sinu eesnimi ja perekonnanimi on võrdse pikkusega.");
            }




        }
    }
}
