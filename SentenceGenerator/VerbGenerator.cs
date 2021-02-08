using LatinWords;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentenceGenerator
{
    public class VerbGenerator
    {
        private VerbInstance Verb { get; set; }
        private readonly Random rnd;
        private readonly WordList vocabList;

        public VerbGenerator()
        {
            rnd = new Random();
            vocabList = new WordList();
        }

        public VerbInstance CreateRandomVerb()
        {
            // Pick a random verb from the word-list (principal parts, conjugation, meaning, etc.)
            Verb = vocabList.GetRandomVerb();

            // Fill out specific verb elements (person, number, tense, mood, voice)
            Verb.Person = GetRandomPerson();
            Verb.Number = GetRandomNumber();
            Verb.Tense = Tense.Present;
            Verb.Mood = Mood.Indicative;
            Verb.Voice = Voice.Active;

            return Verb;
        }
        private Person GetRandomPerson()
        {
            int personCount = 3;
            return (Person)rnd.Next(0, personCount - 1);
        }
        private Number GetRandomNumber()
        {
            int numberCount = 2;
            return (Number)rnd.Next(0, numberCount - 1);
        }

    }
}
