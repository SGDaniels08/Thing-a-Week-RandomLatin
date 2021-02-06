using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords
{
    public class Verb : Word
    {
        // Properties
        public Conjugation Conjugation { get; set; }
        public string FirstPrincipalPart { get; set; }
        public string SecondPrincipalPart { get; set; }
        public string ThirdPrincipalPart { get; set; }
        public string FourthPrincipalPart { get; set; }
        public bool IsDeponent { get; set; }
        public bool IsSemiDeponent { get; set; }
    }
}
