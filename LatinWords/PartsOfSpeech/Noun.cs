using System;

namespace LatinWords
{
    public class Noun : Word
    {
        // Properties
        public Declension Declension { get; set; }
        public Gender Gender { get; set; }
        public string FirstPrincipalPart { get; set; }
        public string SecondPrincipalPart { get; set; }

        public Noun()
        {
            this.PartOfSpeech = PartOfSpeech.Noun;
        }
    }
}
