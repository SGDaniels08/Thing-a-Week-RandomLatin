using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords
{
    public abstract class Word
    {
        // Properties
        public PartOfSpeech PartOfSpeech { get; set; }
        public bool IsRegular { get; set; }
    }
}
