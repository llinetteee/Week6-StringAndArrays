using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {

            //programm kuvab konsoolis mitu 'H', 'O' ja 'L' tähte on lauses "Hello World"
            //char a = 'a'
            //3 counterit ja pikk if lauseblokk

            Console.WriteLine("Hello, World!");

            string helloW = "Hello, World!".ToLower();

            int hCounter = 0;
            int oCounter = 0;
            int lCounter = 0;


            for (int i = 0; i < helloW.Length; i++)
            {

                if (helloW[i] == 'h')
                {

                    hCounter++;

                }
                if (helloW[i] == 'o')
                {

                    oCounter++;

                }
                if (helloW[i] == 'l')
                {

                    lCounter++;

                }


            }

            Console.WriteLine("Hello, World! lauses on: ");

            if (hCounter != 1)

            {

                Console.WriteLine($"{hCounter} 'h' tähte.");

            }

            else

            {

                Console.WriteLine($"{hCounter} 'h' tähte.");

            }

            if (oCounter != 1)

            {

                Console.WriteLine($"{oCounter} 'o' tähte.");

            }

            else

            {

                Console.WriteLine($"{oCounter} 'o' tähte.");

            }

            if (lCounter != 1)

            {

                Console.WriteLine($"{lCounter} 'l' tähte.");

            }

            else

            {

                Console.WriteLine($"{lCounter} 'l' tähte.");

            }


        }
    }
}
