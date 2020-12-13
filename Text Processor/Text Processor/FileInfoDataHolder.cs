using System;

namespace Text_Processor
{
    internal class FileInfoDataHolder
    {

        bool[] filePermission;
        public FileInfoDataHolder(String fileSafeName, string fileFullName,long fileSize, bool[] filePermission)
        {
            this.fileSafeName = fileSafeName;
            this.fileFullName = fileFullName;
            this.fileSize = fileSize;
            this.filePermission = filePermission;
        }

        public string fileFullName { get; set; }
        public string fileSafeName { get; set; }
        public long fileSize { get; set; }

        public override string ToString()
        {
            return fileSafeName;
        }
    }
    internal class storeSearchData {

        public storeSearchData(string FoundWord, int Found_Word_index, int foundWord_length) {
            this.FoundWord = FoundWord;
            this.foundWord_length = foundWord_length;
            this.Found_Word_index = Found_Word_index;
        }
        public string FoundWord { get; set; }
        public int Found_Word_index { get; set; }
        public int foundWord_length { get; set; }

    }


}