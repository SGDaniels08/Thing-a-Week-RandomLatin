using LatinWords;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentenceGenerator
{
    public class NounGenerator
    {
        // Properties
        private NounInstance Noun { get; set; }
        private readonly Random rand;

        public NounGenerator()
        {
            rand = new Random();
        }
        public NounInstance CreateNominativeNoun(List<Word> sentence = null)
        {
            if (Noun == null)
                Noun = new NounInstance();

            // See if there is already a nominative or a verb
            Noun.Gender = GetRandomGender();
            Noun.Number = GetRandomNumber();
            Noun.Case = Case.Nominative;
            return Noun;
        }

        private Gender GetRandomGender()
        {
            int genderCount = 3;
            return (Gender) rand.Next(0, genderCount - 1);
        }
        private Number GetRandomNumber()
        {
            int numberCount = 2;
            return (Number)rand.Next(0, numberCount - 1);
        }
    }
}
