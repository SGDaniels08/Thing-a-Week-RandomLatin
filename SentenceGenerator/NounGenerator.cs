using LatinWords;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentenceGenerator
{
    public class NounGenerator
    {
        // Properties
        private Noun Noun { get; set; }

        public Noun CreateNominative(List<Word> sentence = null)
        {
            if (Noun == null)
                Noun = new Noun();

            // See if there is already a nominative or a verb
            Noun.Case = "nominative";
            return Noun;
        }
    }
}
