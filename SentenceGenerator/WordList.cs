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
            PartOfSpeech = PartOfSpeech.Noun,
            Meaning = "farmer"
        };
        public Noun puella = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Feminine,
            FirstPrincipalPart = "puella",
            SecondPrincipalPart = "puellae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun,
            Meaning = "girl"
        };
        public Noun rosa = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Feminine,
            FirstPrincipalPart = "rosa",
            SecondPrincipalPart = "rosae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun,
            Meaning = "rose"
        };
        public Noun pirata = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Masculine,
            FirstPrincipalPart = "pirata",
            SecondPrincipalPart = "piratae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun,
            Meaning = "pirate"
        };
        public Noun cucurbita = new Noun
        {
            Declension = Declension.First,
            Gender = Gender.Feminine,
            FirstPrincipalPart = "cucurbita",
            SecondPrincipalPart = "cucurbitae",
            IsRegular = true,
            PartOfSpeech = PartOfSpeech.Noun,
            Meaning = "gourd"
        };

        public Verb amo = new Verb
        {
            Conjugation = Conjugation.First,
            FirstPrincipalPart = "amo",
            SecondPrincipalPart = "amare",
            ThirdPrincipalPart = "amavi",
            FourthPrincipalPart = "amatus",
            IsDeponent = false,
            IsSemiDeponent = false,
            Meaning = "love"
        };
        public Verb culpo = new Verb
        {
            Conjugation = Conjugation.First,
            FirstPrincipalPart = "culpo",
            SecondPrincipalPart = "culpare",
            ThirdPrincipalPart = "culpavi",
            FourthPrincipalPart = "culpatus",
            IsDeponent = false,
            IsSemiDeponent = false,
            Meaning = "blame"
        };
        public Verb laudo = new Verb
        {
            Conjugation = Conjugation.First,
            FirstPrincipalPart = "laudo",
            SecondPrincipalPart = "laudare",
            ThirdPrincipalPart = "laudavi",
            FourthPrincipalPart = "laudatus",
            IsDeponent = false,
            IsSemiDeponent = false,
            Meaning = "praise"
        };
        public Verb cacchino = new Verb
        {
            Conjugation = Conjugation.First,
            FirstPrincipalPart = "cacchino",
            SecondPrincipalPart = "cacchinare",
            ThirdPrincipalPart = "cacchinavi",
            FourthPrincipalPart = "cacchinatus",
            IsDeponent = false,
            IsSemiDeponent = false,
            Meaning = "guffaw"
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
            this.nouns.Add(pirata);
            this.nouns.Add(cucurbita);

            this.verbs.Add(amo);
            this.verbs.Add(culpo);
            this.verbs.Add(laudo);
            this.verbs.Add(cacchino);
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
            toReturn.Meaning = tempNoun.Meaning;

            return toReturn;
        }

        public VerbInstance GetRandomVerb()
        {
            int index = rnd.Next(0, verbs.Count - 1);
            Verb tempVerb = verbs[index];
            VerbInstance toReturn = new VerbInstance();

            toReturn.Conjugation = tempVerb.Conjugation;
            toReturn.FirstPrincipalPart = tempVerb.FirstPrincipalPart;
            toReturn.SecondPrincipalPart = tempVerb.SecondPrincipalPart;
            toReturn.ThirdPrincipalPart = tempVerb.ThirdPrincipalPart;
            toReturn.FourthPrincipalPart = tempVerb.FourthPrincipalPart;
            toReturn.IsDeponent = tempVerb.IsDeponent;
            toReturn.IsSemiDeponent = tempVerb.IsSemiDeponent;
            toReturn.Meaning = tempVerb.Meaning;

            return toReturn;
        }
    }
}
