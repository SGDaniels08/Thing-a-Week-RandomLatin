using LatinWords;
using System;
using System.Collections.Generic;

namespace SentenceGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            NounInstance nominative;
            NounInstance accusative;
            VerbInstance verb;
            List<Word> sentence = new List<Word>();
            NounGenerator ng = new NounGenerator();
            VerbGenerator vg = new VerbGenerator();
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
                    nominative = ng.CreateNominativeInstance();
                    nominative.ParsedForm = nominative.GetParsedForm();
                    sentence.Add(nominative);
                }
                if (input == "2")
                {
                    accusative = ng.CreateAccusativeInstance();
                    accusative.ParsedForm = accusative.GetParsedForm();
                    sentence.Add(accusative);
                }
                if (input == "3")
                {
                    verb = vg.CreateRandomVerb();
                    verb.ParsedForm = verb.GetParsedForm();
                    sentence.Add(verb);
                }

                foreach (Word word in sentence)
                {
                    Console.Write($"{word.ParsedForm} ");
                }
                Console.WriteLine("");
            } while (input != "Q");
        }
    }
}
