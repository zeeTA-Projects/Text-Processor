using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace Text_Processor
{
    public partial class TexBox_Components : Form
    {
        ArrayList importedFiles;    // here we add some sample files into this list.
        public TexBox_Components()
        {
            InitializeComponent();

            importedFiles = new ArrayList();
            importedFiles.Add(@"C:\Users\Faisal\Downloads\Text-Processor-main\Text-Processor\SampleFile1.txt");
            importedFiles.Add(@"C:\Users\Faisal\Downloads\Text-Processor-main\Text-Processor\SampleFile2.txt");
        }

        private void Bold_BTN_Click(object sender, EventArgs e)
        {
            Bold_Function();
        }

        private void Italic_BTN_Click(object sender, EventArgs e)
        {
            Italic_Function();
        }

        private void UnderLine_BTN_Click(object sender, EventArgs e)
        {
            UnderLine_Function();
        }

        private void HighLight_BTN_Click(object sender, EventArgs e)
        {
            HighLight_Function();
        }

        private void Search_Filter_BTN_Click(object sender, EventArgs e)
        {

        }

        private void FindFilter_BTN_Click(object sender, EventArgs e)
        {

        }

        private void Scrapping_BTN_Click(object sender, EventArgs e)
        {

        }

        private void ReplaceFilter_BTN_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function();
        }

        
        // form event 
        private void TexBox_Components_Load(object sender, EventArgs e)
        {
            foreach (string fileName in importedFiles)
            {
                listBox1.Items.Add(fileName);  // adding files from array to list box
            }
        }

        //Set Size of Rich TextBOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSize_Function();
        }

        //set font style of richTextBox
        private void SetFont_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont_Function();
        }

        //Bold Function
        public void Bold_Function()
        {

            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Bold);
        }


        // Italic Function
        public void Italic_Function()
        {
            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Italic);
        }

        //UnderLine Function
        public void UnderLine_Function()
        {

            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Underline);
        }

        //HighLight Function 
        public void HighLight_Function()
        {
            ComponentTexting_Box.SelectionBackColor = Color.Yellow;
        }


        //Text size Set Function
        public void SetSize_Function()
        {
            
            if (comboBox1.SelectedItem != null)
            {
               int size = Int32.Parse(comboBox1.SelectedItem.ToString());
                ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, size, SystemFonts.DefaultFont.Style);

            }
            else {
               
                ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);

            }
        }

        //font type  Set Functions
        public void SetFont_Function()
        {
            string Font = SetFont_box.SelectedItem.ToString();
            ComponentTexting_Box.SelectionFont = new Font(Font, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);

        }

        //Search Filter Function

        public void SearchFilter_Function()
        {

        }

        // select a file to open in rich text box
        public void Select_File_To_Open_Function()
        {
            string SelectedFileName = listBox1.SelectedItem.ToString(); //store selected list box value into a string


            //Now open file and print its data to rich text box
            FileInfo fi = new FileInfo(SelectedFileName);
            if (fi.Exists)
            {
                using (StreamReader readFile = fi.OpenText())
                {
                    string readData = "";
                    while ((readData = readFile.ReadLine()) != null)
                        ComponentTexting_Box.Text += readData;
                }
            }

        }

    }
}
