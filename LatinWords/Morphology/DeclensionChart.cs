using System.Collections.Generic;

namespace LatinWords
{
    public class DeclensionChart
    {
        // Properties
        public Dictionary<string, string> FullChart { get; set; }
        public string NomSing { get; set; }
        public string GenSing { get; set; }
        public string DatSing { get; set; }
        public string AccSing { get; set; }
        public string AblSing { get; set; }
        public string VocSing { get; set; }
        public string NomPlur { get; set; }
        public string GenPlur { get; set; }
        public string DatPlur { get; set; }
        public string AccPlur { get; set; }
        public string AblPlur { get; set; }
        public string VocPlur { get; set; }
    }
}