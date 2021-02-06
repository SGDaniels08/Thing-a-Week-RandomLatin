using LatinWords;
using System;
using System.Collections.Generic;

namespace SentenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Noun nominative;
            Noun accusative;
            Verb verb;
            List<Word> sentence = new List<Word>();
            NounGenerator ng = new NounGenerator();
            string input;

            Console.WriteLine("Welcome to Random Latin Generator!");
            Console.WriteLine("This will create a simple random Subject-Verb-Object sentence.");
            do
            {
                Console.WriteLine("\nChoose which word you wish to generate: ");
                Console.WriteLine("     1) Nominative noun (subject)");
                Console.WriteLine("     2) Accusative noun (object)");
                Console.WriteLine("     3) Verb (present active indicative)");
                Console.Write("\n>> ");
                input = Console.ReadLine().ToUpper();

                if (input == "1")
                {
                    nominative = ng.CreateNominativeNoun();
                    sentence.Add(nominative);
                }
                if (input == "2")
                {
                    Console.WriteLine("ACCUSATIVE NOUN");
                }
                if (input == "3")
                {
                    Console.WriteLine("VERB");
                }
            } while (input != "Q");
        }
    }
}
