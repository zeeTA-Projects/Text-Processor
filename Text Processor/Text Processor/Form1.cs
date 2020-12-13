using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Text_Processor
{
    public partial class TexBox_Components : Form
    {   
       
        public TexBox_Components()
        {
            InitializeComponent();

            importedFiles = new ArrayList();
<<<<<<< Updated upstream
            importedFiles.Add(@"C:\Users\Faisal\Downloads\Text-Processor-main\Text-Processor\SampleFile1.txt");
            importedFiles.Add(@"C:\Users\Faisal\Downloads\Text-Processor-main\Text-Processor\SampleFile2.txt");
        }
    }
=======
            storeSearchData = new ArrayList();
            storeScrappingFiles = new ArrayList();
            importedFiles.Add(new FileInfoDataHolder("SampleFile1.txt", @"C:\Users\Faisal\Desktop\Text-Processor-main\Text-Processor\SampleFile1.txt",0,null));
            importedFiles.Add(new FileInfoDataHolder("SampleFile2.txt", @"C:\Users\Faisal\Desktop\Text-Processor-main\Text-Processor\SampleFile2.txt",0,null));
        }

    } 
>>>>>>> Stashed changes
}