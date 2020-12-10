using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Text.RegularExpressions;
namespace Text_Processor
{
   public partial class TexBox_Components
    {
        private ArrayList importedFiles;    // here we add some sample files into this list.
        static string getDataFromFile="";
        static int NumberOfMatches=0;

       // all action listener start from here
        private void HighLight_BTN_Click(object sender, EventArgs e)
        {
            HighLight_Function(richTextbox1);
        }

        private void Italic_BTN_Click(object sender, EventArgs e)
        {
            Italic_Function(richTextbox1);
        }

        private void UnderLine_BTN_Click(object sender, EventArgs e)
        {
            
            UnderLine_Function(richTextbox1);
        }
        private void Bold_BTN_Click(object sender, EventArgs e)
        {
            Bold_Function(richTextbox1);
        }

        // clear button to clear richtext box
        private void Clear_richTextBox_Click(object sender, EventArgs e)
        {
            richTextbox1.Clear();
        }

        // combo box event to set size of richbx selected text
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //Set Size of Rich TextBOX
        {
            SetSize_Function();
        }

       
        // combo box event to set font of richbx selected text
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) //set font style of richTextBox
        {
            SetFont_Function();
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox1);
        }

        // form event
        private void TexBox_Components_Load(object sender, EventArgs e)
        {

            pnlFindPanel.Visible = false;
            pnlSearchPanel.Visible = false;
            pnlScappingPanel.Visible = false;
            pnlReplacePanel.Visible = false;

            pnlSearchPanel.Location = new Point(572, 134);
            pnlFindPanel.Location = new Point(572, 134); ;
            pnlReplacePanel.Location= new Point(572, 134);
            pnlScappingPanel.Location= new Point(572, 134); ;

            AddFileToListbox_function(listBox1);


        }



        // this bold function, will call in bold button to set text of richtextbox bold
        public void Bold_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Bold);
        }

        //HighLight Function
        public void HighLight_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionBackColor = Color.Yellow;
        }

        // Italic Function
        public void Italic_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Italic);
        }

        //UnderLine Function
        public void UnderLine_Function(RichTextBox richTextbox_text_processor)
        {
            richTextbox_text_processor.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Underline);
        }

        // there function are passed to to combo box event to get selected value from combo box and edit rich text box according to that
        //font type  Set Functions
        public void SetFont_Function()
        {
            string Font = comboBox2.SelectedItem.ToString();
            richTextbox1.SelectionFont = new Font(Font, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
        }

        //Text size Set Function
        public void SetSize_Function()
        {
            if (comboBox1.SelectedItem != null)
            {
                int size = Int32.Parse(comboBox1.SelectedItem.ToString());
                richTextbox1.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, size, SystemFonts.DefaultFont.Style);
            }
            else
            {
                richTextbox1.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
            }
        }

       


        /**  
         *  from here code to find filter start
         *  
         *
         * */
        private void FindFilter_BTN_Click(object sender, EventArgs e)    // event for find filter button 
        {
            pnlFindPanel.Visible = true;     // here we make find filter panel visible to user
            pnlFindPanel.BringToFront();  // bring panel to front

            AddFileToListbox_function(Listbox_findFilter);
        }

        //browse button event
        private void Browse_FindFilter_btn_Click(object sender, EventArgs e)
        {   // here it gets text from  target text field which would be name of file
            BrowseFile_function(TargetFile_txt.Text);  // get any name of file to open
        } 

        private void Listbox_findFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(Listbox_findFilter);
        }
        private void Search1_FindFilter_btn_Click(object sender, EventArgs e)
        {
           Search1_FindFilter_function(Start_FindFilter_txt.Text,End_FindFilter_txt.Text);
        }

        private void Search2_FindFilter_btn_Click(object sender, EventArgs e)
        {
            Search2_FindFilter_function(Start_FindFilter_txt.Text, End_FindFilter_txt.Text,Contain_FindFilter_txt.Text);
        }

        private void HighLight_FindFilter_btn_Click(object sender, EventArgs e)
        {

        }

        /**
         * from here code for search filter starts
        **/
        private void Search_Filter_BTN_Click(object sender, EventArgs e)
        {
            pnlSearchPanel.Visible = true;
            pnlSearchPanel.BringToFront();
            AddFileToListbox_function(listBox2);
        }


        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox2);
        }

        private void Browse_searchFilter_btn_Click(object sender, EventArgs e)
        {
            BrowseFile_function(targetFile_searchFilter_txt.Text);
        }

        private void SearchSentence_SearchFilter_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void HighlightSentence_SearchFilter_btn_Click(object sender, EventArgs e)
        {

        }


        private void Search_words_SearchFilter_btn_Click(object sender, EventArgs e)
        {

        }

        private void HighlightWord_SearchFilter_btn_Click(object sender, EventArgs e)
        {

        }

        /**
         * from here replace filter starts
         * **/
        private void ReplaceFilter_BTN_Click(object sender, EventArgs e)
        {
            pnlReplacePanel.Visible = true;
            pnlReplacePanel.BringToFront();
            AddFileToListbox_function(listBox7);
        }

        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox7);
        }

        private void Browse_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            BrowseFile_function(TargetFile_ReplaceFilter_txt.Text);
        }

        private void search1_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            Search1_FindFilter_function(start_ReplaceFilter_txt.Text,end_ReplaceFilter_txt.Text);
        }

        private void search2_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            Search2_FindFilter_function(start_ReplaceFilter_txt.Text, end_ReplaceFilter_txt.Text,Contain_FindFilter_txt.Text);
        }

        private void Replace_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {

        }


        /**
         * from here scrapping filter starts
         * **/


        private void Scrapping_BTN_Click(object sender, EventArgs e)
        {
            pnlScappingPanel.Visible = true;
            pnlScappingPanel.BringToFront();
        }


        /**
         * from here read filter starts
         * **/


        private void Read_Data_btn_Click(object sender, EventArgs e)
        {

        }
        //*********************************  these functions are called in more than one events

        //Browse button which take any drive or folder name and took  all available files from it
        void BrowseFile_function(string FileName)
        {
            FileInfo fi = new FileInfo(FileName); // open targeted file
            if (fi.Exists)
            {
                FileStatus.Text = "opened File: " + FileName; //show open file name to label
                using (StreamReader readFile = fi.OpenText())
                {
                    string readData = "";
                    while ((readData = readFile.ReadLine()) != null)
                        getDataFromFile += readData;
                    richTextbox1.Text += readData;

                }
            }
            else
            {
                FileStatus.Text = "file not opened"; //show file status not open
            }
        }

        // method to add file to listbox
        void AddFileToListbox_function(ListBox listBox)
        {
            foreach (string fileName in importedFiles)
            {
                listBox.Items.Add(fileName);  // adding files from array to list box
            }
        }


        // select one or multiple file to open in rich text box
        // this function will call at list box selected listener
        // this function would be call many time 

        public void Select_File_To_Open_Function(ListBox listBox)
        {
            getDataFromFile = ""; // first make data string clear ....  this string use if we use list box for filters

            foreach (object SelectedFileName in listBox.SelectedItems)  // get each selected item
            {



                //Now open file and print its data to rich text box
                FileInfo fi = new FileInfo(SelectedFileName.ToString());
                if (fi.Exists)
                {
                    using (StreamReader readFile = fi.OpenText())
                    {
                        string readData = "";
                        while ((readData = readFile.ReadLine()) != null)
                          richTextbox1.Text += readData;
                        getDataFromFile += readData; // adding data to string as well bcz this is calling multiple time for different usage
                    }
                }
            }


        }

        // funtions that use for search in (replace and find filters)


        //Search Function for find filter command
        // for that we take two values from users 1. start and 2. end
        void Search1_FindFilter_function(string StartVal, string EndVal)
        {
            NumberOfMatches = 0;
            

            string givenPat = StartVal + "[a-zA-Z0-9]+" + EndVal;
            Regex pattern = new Regex(givenPat);
            string[] words = richTextbox1.Text.Split(' ');
            richTextbox1.Text = "";
            foreach (string word in words)
            {
                MatchCollection miCollection = pattern.Matches(word);



                foreach (Match match in miCollection)
                {
                    richTextbox1.Text += String.Format(match.Value + "\n ");
                    /*
                     * Better is store the details like .. starting index of search ...
                     */

                    NumberOfMatches++;
                }

            }


        }

        //Search2 Function for find filter command
        // for that we take a which find filter for in between 
        void Search2_FindFilter_function(string StartVal, string EndVal, string inBetween)
        {
            NumberOfMatches = 0;

            richTextbox1.Clear();
            if (StartVal != null && EndVal == null)
            {
                string givenPat = @"\s^" + StartVal + "+" + inBetween + @"[a-zA-Z0-9]$\s";
                Regex pattern = new Regex(givenPat);
                MatchCollection miCollection = pattern.Matches(getDataFromFile);
                foreach (Match match in miCollection)
                {
                    richTextbox1.Text += String.Format(match.Value + " ");
                    NumberOfMatches++;
                }
            }
            else if (StartVal == null && EndVal != null)
            {
                string givenPat = @"\s^[a-zA-Z0-9]+" + inBetween + EndVal + @"+$\s";
                Regex pattern = new Regex(givenPat);
                MatchCollection miCollection = pattern.Matches(getDataFromFile);
                foreach (Match match in miCollection)
                {
                    richTextbox1.Text += String.Format(match.Value + " ");
                    NumberOfMatches++;
                }
            }
            else if (StartVal == null && EndVal == null)
            {


                string givenPat = @"\s^" + StartVal + "+" + inBetween + @"[a-zA-Z0-9]$\s";
                Regex pattern = new Regex(givenPat);
                MatchCollection miCollection = pattern.Matches(getDataFromFile);
                foreach (Match match in miCollection)
                {
                    richTextbox1.Text += String.Format(match.Value + " ");
                    NumberOfMatches++;
                }
            }
            else
            {
                string givenPat = @"\s^" + StartVal + "+" + inBetween + EndVal + @"+$\s";
                Regex pattern = new Regex(givenPat);
                MatchCollection miCollection = pattern.Matches(getDataFromFile);
                foreach (Match match in miCollection)
                {
                    richTextbox1.Text += String.Format(match.Value + " ");
                    NumberOfMatches++;
                }
            }


        }




    }
}
