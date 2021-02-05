using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords
{
    public class Verb : Word
    {
        // Properties
        public string Declension { get; set; }
        public string FirstPrincipalPart { get; set; }
        public string SecondPrincipalPart { get; set; }
        public string ThirdPrincipalPart { get; set; }
        public string FourthPrincipalPart { get; set; }
        public string Person { get; set; }
        public string Number { get; set; }
        public string Tense { get; set; }
        public string Mood { get; set; }
        public string Voice { get; set; }
    }
}
