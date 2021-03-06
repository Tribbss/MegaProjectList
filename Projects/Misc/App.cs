﻿using System;
using Misc.Text;

namespace Misc
{
    internal class App
    {

        private static void Main()
        {
			// Deals with all the different fucntions
            Run();           

			// keep the console alive until the user hits a key after the above ^
            Console.Read();
        }

        private static void Run()
        {
            StringReverse.Init();

            Console.WriteLine("");
            PigLatin.Init();

            Console.WriteLine("");
            VowelCount.Init();

            Console.WriteLine("");
            Palindrome.CheckIfPalindrome();

            Console.WriteLine("");
            WordsInString.Init();

            Console.WriteLine("");
            KeyGeneration.Generate();
        }
    }
}
