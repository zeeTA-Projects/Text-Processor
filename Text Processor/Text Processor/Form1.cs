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
            importedFiles.Add(@"C:\Users\Faisal\Downloads\Text-Processor-main\Text-Processor\SampleFile1.txt");
            importedFiles.Add(@"C:\Users\Faisal\Downloads\Text-Processor-main\Text-Processor\SampleFile2.txt");
        }
    }
}