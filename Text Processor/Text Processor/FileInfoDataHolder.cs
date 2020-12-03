using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Processor
{


    class FileInfoDataHolder
    {
        
        public string fileSafeName { get; set; }
        public string fileFullName { get; set; }
        public int fileSize { get; set; }

        public bool[] filePermissions;

        public FileInfoDataHolder(String fileSafeName,string fileFullName,int fileSize,bool[] filePermissions)
        {
            this.fileSafeName = fileSafeName;
            this.fileFullName = fileFullName;
            this.fileSize = fileSize;
            this.filePermissions = filePermissions;
        }


    }
}
