using System;

namespace Text_Processor
{
    internal class FileInfoDataHolder
    {
        public bool[] filePermissions;

        public FileInfoDataHolder(String fileSafeName, string fileFullName, int fileSize, bool[] filePermissions)
        {
            this.fileSafeName = fileSafeName;
            this.fileFullName = fileFullName;
            this.fileSize = fileSize;
            this.filePermissions = filePermissions;
        }

        public string fileFullName { get; set; }
        public string fileSafeName { get; set; }
        public int fileSize { get; set; }
    }
}