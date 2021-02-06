using System;
using System.Collections.Generic;
using System.Text;

namespace LatinWords
{
    public class VerbInstance : Verb
    {
        // Properties
        public Person Person { get; set; }
        public Number Number { get; set; }
        public Tense Tense { get; set; }
        public Mood Mood { get; set; }
        public Voice Voice { get; set; }
    }
}
