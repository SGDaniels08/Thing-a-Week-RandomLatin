using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords.Morphology
{
    public static class VerbConstants
    {
        public static PersonalEndings OSTMUSTISNT = new PersonalEndings
        {
            FirstSingular = "o",
            SecondSingular = "s",
            ThirdSingular = "t",
            FirstPlural = "mus",
            SecondPlural = "tis",
            ThirdPlural = "nt"
        };

        public static ThematicVowels FirstConjugationPresentIndicative = new ThematicVowels
        {
            FirstSingular = "",
            SecondSingular = "a",
            ThirdSingular = "a",
            FirstPlural = "a",
            SecondPlural = "a",
            ThirdPlural = "a"
        };
    }
}
