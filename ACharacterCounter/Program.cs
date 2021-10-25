using System;

namespace ACharacterCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //ees ja perekonnanimi
            //mit a tähte on kokku mõlemas nimes

            Console.WriteLine("Sisesta eesnimi: ");
            string FirstName = Console.ReadLine();

 
            Console.WriteLine("Sisesta perekonnanimi: ");
            string LastName = Console.ReadLine();


            string fullName = $"{FirstName}{LastName}".ToLower();

            Console.WriteLine(fullName);

            int aCounter = 0;

            for (int i = 0; i < fullName.Length; i++)
            {

                if (fullName[i] == 'a')
                {

                    aCounter++;

                }

            }

            if (aCounter != 1)
            {
                Console.WriteLine($"Sinu täisnimes on {aCounter} 'a' tähte.");
            }
            else
            {

                Console.WriteLine($"Sinu eesnimes on {aCounter} 'a' tähte.");
            }
        }
    }

}