﻿using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //program asendab kõik 'o' tähed lauses "Hello World!" tärniga


            string helloW = "Hello World!";

            /*for (int i = 0; i < helloW.Length; i++)
            {
                helloW[i] = '*'; //sõned on muutumatud

            }*/

            helloW = helloW.Replace('o', '*');

            helloW = helloW.Replace('!', '1');

            Console.WriteLine(helloW);

        }
    }
}
