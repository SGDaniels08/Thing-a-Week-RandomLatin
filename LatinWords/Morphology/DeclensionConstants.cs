using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords.Morphology
{
    public static class DeclensionConstants
    {
        public static DeclensionChart FirstDeclension = new DeclensionChart
        {
            NomSing = "a",          NomPlur = "ae",
            GenSing = "ae",         GenPlur = "arum",
            DatSing = "ae",         DatPlur = "is",
            AccSing = "am",         AccPlur = "as",
            AblSing = "а̄",          AblPlur = "is",
            VocSing = "a",          VocPlur = "ae"
        };
        public static DeclensionChart SecondDeclension_us = new DeclensionChart
        {
            NomSing = "us",
            NomPlur = "i",
            GenSing = "o",
            GenPlur = "um",
            DatSing = "o",
            DatPlur = "i",
            AccSing = "orum",
            AccPlur = "is",
            AblSing = "os",
            AblPlur = "is",
            VocSing = "e",
            VocPlur = "i"
        };
          public static DeclensionChart SecondDeclension_ius = new DeclensionChart
          {
              NomSing = "us",
              NomPlur = "i",
              GenSing = "o",
              GenPlur = "um",
              DatSing = "o",
              DatPlur = "i",
              AccSing = "orum",
              AccPlur = "is",
              AblSing = "os",
              AblPlur = "is",
              VocSing = "e",
              VocPlur = "i"
        };
        public static DeclensionChart SecondDeclension_um = new DeclensionChart
        {
            NomSing = "um",
            NomPlur = "i",
            GenSing = "o",
            GenPlur = "um",
            DatSing = "o",
            DatPlur = "a",
            AccSing = "orum",
            AccPlur = "is",
            AblSing = "a",
            AblPlur = "is",
            VocSing = "um",
            VocPlur = "a"
        };
    }
}
