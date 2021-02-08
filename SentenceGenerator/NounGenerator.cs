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
        private readonly WordList vocabList;

        public NounGenerator()
        {
            rand = new Random();
            vocabList = new WordList();
        }
        public NounInstance CreateNominativeInstance(List<Word> sentence = null)
        {
            // Pick a random noun from the word-list (principal parts, declension, meaning, etc.)
            Noun = vocabList.GetRandomNoun();

            // Fill out other noun elements (gender, number, case)
            Noun.Number = GetRandomNumber();
            Noun.Case = Case.Nominative;
            return Noun;
        }

        public NounInstance CreateAccusativeInstance(List<Word> sentence = null)
        {
            // Pick a random noun from the word-list (principal parts, declension, meaning, etc.)
            Noun = vocabList.GetRandomNoun();

            // Fill out other noun elements (gender, number, case)
            Noun.Number = GetRandomNumber();
            Noun.Case = Case.Accusative;
            return Noun;
        }

        private Number GetRandomNumber()
        {
            int numberCount = 2;
            return (Number)rand.Next(0, numberCount - 1);
        }
    }
}
