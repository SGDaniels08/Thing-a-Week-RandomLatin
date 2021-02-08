using LatinWords.Morphology;
using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords
{
    public class NounInstance : Noun
    {
        public Number Number { get; set; }
        public Case Case { get; set; }

        public string GetParsedForm()
        {
            ParsedForm = GetNounStem();
            DeclensionChart chart = GetDeclensionChart();
            ParsedForm += GetNounEnding(chart);

            return ParsedForm;
        }

        private string GetNounEnding(DeclensionChart chart)
        {
            if (this.Number == Number.Singular)
            {
                if (this.Case == Case.Nominative)
                    return chart.NomSing;
                else if (this.Case == Case.Genitive)
                    return chart.GenSing;
                else if (this.Case == Case.Dative)
                    return chart.DatSing;
                else if (this.Case == Case.Accusative)
                    return chart.AccSing;
                else if (this.Case == Case.Ablative)
                    return chart.AblSing;
                else if (this.Case == Case.Vocative)
                    return chart.VocSing;
            }
            else if (this.Number == Number.Plural)
            {
                if (this.Case == Case.Nominative)
                    return chart.NomPlur;
                else if (this.Case == Case.Genitive)
                    return chart.GenPlur;
                else if (this.Case == Case.Dative)
                    return chart.DatPlur;
                else if (this.Case == Case.Accusative)
                    return chart.AccPlur;
                else if (this.Case == Case.Ablative)
                    return chart.AblPlur;
                else if (this.Case == Case.Vocative)
                    return chart.VocPlur;
            }
            return null;
        }

        private DeclensionChart GetDeclensionChart()
        {
            if (this.Declension == Declension.First) 
                return NounConstants.FirstDeclension;
            if (this.Declension == Declension.Second)
                return NounConstants.SecondDeclension_us;
            else
                return NounConstants.FirstDeclension;
        }

        private string GetNounStem()
        {
            int genSingLength;
            
            if (this.Declension == Declension.Second)
            {
                genSingLength = 1;
            }
            else
            {
                genSingLength = 2;
            }

            return this.SecondPrincipalPart.Substring(0, SecondPrincipalPart.Length - genSingLength);
        }
    }
}
