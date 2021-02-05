using System;

namespace LatinWords
{
    public class Noun : Word
    {
        // Properties
        public string Declension { get; set; }
        public string FirstPrincipalPart { get; set; }
        public string SecondPrincipalPart { get; set; }
        public string Gender { get; set; }
        public string Number { get; set; }
        public string Case { get; set; }
    }
}
