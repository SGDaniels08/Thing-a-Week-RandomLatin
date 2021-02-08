using LatinWords;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentenceGenerator
{
    public class WordList
    {
        private Random rnd;
        public List<Word> vocab;
        public List<Noun> nouns;
        public List<Verb> verbs;

        // Nouns
        public Noun agricola = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Masculine,
            FirstPrincipalPart = "agricola",
            SecondPrincipalPart = "agricolae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun
        };
        public Noun puella = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Feminine,
            FirstPrincipalPart = "puella",
            SecondPrincipalPart = "puellae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun
        };
        public Noun rosa = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Feminine,
            FirstPrincipalPart = "rosa",
            SecondPrincipalPart = "rosae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun
        };

        public WordList()
        {
            rnd = new Random();
            vocab = new List<Word>();
            nouns = new List<Noun>();
            verbs = new List<Verb>();

            this.nouns.Add(agricola);
            this.nouns.Add(puella);
            this.nouns.Add(rosa);
        }

        public NounInstance GetRandomNoun()
        {
            int index = rnd.Next(0, nouns.Count - 1);
            Noun tempNoun = nouns[index];
            NounInstance toReturn = new NounInstance();

            toReturn.Declension = tempNoun.Declension;
            toReturn.Gender = tempNoun.Gender;
            toReturn.FirstPrincipalPart = tempNoun.FirstPrincipalPart;
            toReturn.SecondPrincipalPart = tempNoun.SecondPrincipalPart;
            toReturn.PartOfSpeech = tempNoun.PartOfSpeech;

            return toReturn;
        }
    }
}
