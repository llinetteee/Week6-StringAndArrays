using System;

namespace StrinReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab tagurpidi eesnime

            Console.WriteLine("Sisesta eesnimi: ");
            string firstName = Console.ReadLine();


            for(int i = firstName.Length-1; i>= 0;i--)
            {
                Console.Write(firstName[i]);



            }


        }
    }
}
