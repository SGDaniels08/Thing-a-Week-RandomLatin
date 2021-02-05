using LatinWords;
using System;
using System.Collections.Generic;
using System.Text;

namespace SentenceGenerator
{
    public class Sentence
    {
        private List<Word> sentence;

        public Sentence()
        {
            sentence = new List<Word>();
        }

        public bool ContainsNominative()
        {
            foreach (Word word in sentence)
            {
                if (word.PartOfSpeech == PartOfSpeech.Noun)
                {
                    Noun temp = word as Noun;
                    if (temp.Case == "nominative")
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
