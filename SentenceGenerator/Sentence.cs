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
                    NounInstance temp = word as NounInstance;
                    if (temp.Case == Case.Nominative)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void PrintSentence()
        {
            foreach (Word word in sentence)
            {

            }
        }

    }
}
