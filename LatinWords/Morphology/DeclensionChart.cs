using System.Collections.Generic;

namespace LatinWords
{
    public class DeclensionChart
    {
        // Properties
        public Dictionary<string, string> FullChart { get; set; }
        private string NomSing { get; set; }
        private string GenSing { get; set; }
        private string DatSing { get; set; }
        private string AccSing { get; set; }
        private string AblSing { get; set; }
        private string VocSing { get; set; }
        private string NomPlur { get; set; }
        private string GenPlur { get; set; }
        private string DatPlur { get; set; }
        private string AccPlur { get; set; }
        private string AblPlur { get; set; }
        private string VocPlur { get; set; }
    }
}