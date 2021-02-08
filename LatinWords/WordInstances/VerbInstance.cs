using LatinWords.Morphology;
using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords
{
    public class VerbInstance : Verb
    {
        // Properties
        public Person Person { get; set; }
        public Number Number { get; set; }
        public Tense Tense { get; set; }
        public Mood Mood { get; set; }
        public Voice Voice { get; set; }

        public string GetParsedForm()
        {
            ParsedForm = GetVerbStem();
            ParsedForm += GetThematicVowel();
            //ParsedForm += GetInfixes();
            ParsedForm += GetPersonalEnding();

            return ParsedForm;
        }

        private string GetPersonalEnding()
        {
            var personalEndings = VerbConstants.OSTMUSTISNT;
            if (this.Person == Person.First && this.Number == Number.Singular)
                return personalEndings.FirstSingular;
            if (this.Person == Person.Second && this.Number == Number.Singular)
                return personalEndings.SecondSingular;
            if (this.Person == Person.Third && this.Number == Number.Singular)
                return personalEndings.ThirdSingular;
            if (this.Person == Person.First && this.Number == Number.Plural)
                return personalEndings.FirstPlural;
            if (this.Person == Person.Second && this.Number == Number.Plural)
                return personalEndings.SecondPlural;
            if (this.Person == Person.Third && this.Number == Number.Plural)
                return personalEndings.ThirdPlural;

            return null;
        }

        private string GetThematicVowel()
        {
            //switch (this.Conjugation)
            //{
                //case Conjugation.First:
                    var themVowel = VerbConstants.FirstConjugationPresentIndicative;
                    if (this.Person == Person.First && this.Number == Number.Singular)
                        return themVowel.FirstSingular;
                    if (this.Person == Person.Second && this.Number == Number.Singular)
                        return themVowel.SecondSingular;
                    if (this.Person == Person.Third && this.Number == Number.Singular)
                        return themVowel.ThirdSingular;
                    if (this.Person == Person.First && this.Number == Number.Plural)
                        return themVowel.FirstPlural;
                    if (this.Person == Person.Second && this.Number == Number.Plural)
                        return themVowel.SecondPlural;
                    if (this.Person == Person.Third && this.Number == Number.Plural)
                        return themVowel.ThirdPlural;

                    return null;
            //}
        }

        private string GetVerbStem()
        {
            return this.SecondPrincipalPart.Substring(0, SecondPrincipalPart.Length - 3);
        }
    }
}
