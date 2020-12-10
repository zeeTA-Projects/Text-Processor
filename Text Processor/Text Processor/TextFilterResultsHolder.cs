using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processor
{
    class TextFilterResultsHolder
    {
        public string victimFileName { get; set; }
        public string victimWord { get; set; }
        public int victimStartIndex { get; set; }
        public int victimEndIndex { get; set; }

        public TextFilterResultsHolder(string victimFileName, string victimWord, int victimStartIndex, int victimEndIndex)
        {
            this.victimFileName = victimFileName;
            this.victimWord = victimWord;
            this.victimStartIndex = victimStartIndex;
            this.victimEndIndex = victimEndIndex;
        }
    }
}