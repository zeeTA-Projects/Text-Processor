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
        static ArrayList storeSearchData;
        static int NumberOfMatches=0;


        // form event  
        //here we make filter panels invisible
        private void TexBox_Components_Load(object sender, EventArgs e)
        {

            pnlFindPanel.Visible = false;
            pnlSearchPanel.Visible = false;
            pnlScappingPanel.Visible = false;
            pnlReplacePanel.Visible = false;

            pnlSearchPanel.Location = new Point(572, 134);
            pnlFindPanel.Location = new Point(572, 134); ;
            pnlReplacePanel.Location = new Point(572, 134);
            pnlScappingPanel.Location = new Point(572, 134); ;

            AddFileToListbox_function(listBox1); //method that add arraylist of file name in listbox 

        }


        //from here events like hightlight, bold, italic  starts
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
        
        //Main Window listBox shows some file name to select
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox1,richTextbox1); //with this we can select any file that will open in richtextBox
        }

        //******************************************************************************************************************


          
        // these are fnction that we are calling in above events 
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


        //****************************************************************************************************************************






        // ***************** Filters*********************************************************************


        /**  
         *  from here code to find filter start
         *  
         *
         * */


        // event for find filter button 
        private void FindFilter_BTN_Click(object sender, EventArgs e)   
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


        //Listbox selecting any available file
        private void Listbox_findFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(Listbox_findFilter,richTextbox1);
        }


        // this event take first and last value from textBox and filters all related value from richtextbox
        private void Search1_FindFilter_btn_Click(object sender, EventArgs e)
        {
            storeSearchData.Clear();
            richTextBox2.Clear();
            Search1_FindFilter_function(Start_FindFilter_txt.Text,End_FindFilter_txt.Text,richTextbox1.Text);
        }

        // this event take first and last value as well as any value between them from textBox and filters all related value from richtextbox
        private void Search2_FindFilter_btn_Click(object sender, EventArgs e)
        {
            if (!(Contain_FindFilter_txt.Text.Equals("")))
            {
                storeSearchData.Clear(); 
                richTextBox2.Clear();
                Search2_FindFilter_function(Start_FindFilter_txt.Text, End_FindFilter_txt.Text, Contain_FindFilter_txt.Text, richTextbox1.Text);
            }
            else
            {
            }
        }
       

        // in this we hightlight searched word of richTextbox
        private void HighLight_FindFilter_btn_Click(object sender, EventArgs e)
        {

            HighLightSearchedText(richTextbox1, storeSearchData);


        }
        //***********************************FIND FILTER CODE ENDS HERE*****************************************************




        /**
         * from here code for search filter starts
        **/
        private void Search_Filter_BTN_Click(object sender, EventArgs e)
        {
            pnlSearchPanel.Visible = true;
            pnlSearchPanel.BringToFront();
            AddFileToListbox_function(listBox2);
        }

        //Listbox selecting any available file
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox2,richTextbox1);
        }


        //This will browse any file given in a text file if its available
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

        //******************** SEARCH FILTER ENDS HERE************************************************************


        /**
         * from here replace filter starts
         * **/


        //calling panel of replace filter
        private void ReplaceFilter_BTN_Click(object sender, EventArgs e)
        {
            pnlReplacePanel.Visible = true;
            pnlReplacePanel.BringToFront();
            AddFileToListbox_function(listBox7);  // add array of files name in to listbox
        }


        // set selected file content into richtextbox
        private void listBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox7,richTextbox1);
        }


        //browse any file that we want from pc
        private void Browse_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            BrowseFile_function(TargetFile_ReplaceFilter_txt.Text);
        }

        // search for first and last occurrence of any character in word
        private void search1_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            storeSearchData.Clear();
            richTextBox2.Clear();
            Search1_FindFilter_function(start_ReplaceFilter_txt.Text,end_ReplaceFilter_txt.Text, richTextbox1.Text);
        }


        // search for first ,last and in between occurrence of any character in word
        private void search2_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {   if (!(Contain_FindFilter_txt.Text.Equals("")))
            {
                storeSearchData.Clear();
                richTextBox2.Clear();
                Search2_FindFilter_function(start_ReplaceFilter_txt.Text, end_ReplaceFilter_txt.Text, Contain_FindFilter_txt.Text, richTextbox1.Text); }
            else { 
            
            }
        }

        // will replace sea
        private void Replace_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            ReplaceSearchWord_Function(richTextbox1,storeSearchData,ReplaceWith_ReplaceFilter_txt.Text);
        }

        //method for replace 
        void ReplaceSearchWord_Function(RichTextBox richText, ArrayList ReplaceWord,string WordForReplace) {
            for (int i = 0; i < ReplaceWord.Count; i++)
            {

                string[] getWord = ReplaceWord[i].ToString().Split(' ');


                richTextbox1.Text = richText.Text.Replace(getWord[0], WordForReplace);

            }
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
            listBox.Items.Clear();
            foreach (string fileName in importedFiles)
            {
                listBox.Items.Add(fileName);  // adding files from array to list box
            }
        }


        // select one or multiple file to open in rich text box
        // this function will call at list box selected listener
        // this function would be call many time 

        public void Select_File_To_Open_Function(ListBox listBox,RichTextBox richText)
        {
           
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
                          richText.Text += readData;
                       
                    }
                }
            }


        }

        // funtions that use for search in (replace and find filters)


        //Search Function for find filter command
        // for that we take two values from users 1. start and 2. end
        void Search1_FindFilter_function(string StartVal, string EndVal,string Storedata)
        {
            NumberOfMatches = 0;
            int IndexPass = 0;
            if (!(StartVal.Equals("")) && !(EndVal.Equals("")))
            {
                string givenPat = "^"+StartVal + "[a-zA-Z0-9]+" + EndVal+"$";
                Regex pattern = new Regex(givenPat);

                string[] words = Storedata.Split(' ');

                foreach (string word in words)
                {
                   
                    MatchCollection miCollection = pattern.Matches(word);

                    foreach (Match match in miCollection)
                    {
                       richTextBox2.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(match.Value + " " + IndexPass);

                        NumberOfMatches++;
                    }
                    IndexPass += word.Length+1;
                }
            }



        }

        //Search2 Function for find filter command
        // for that we take a which find filter for in between 
        void Search2_FindFilter_function(string StartVal, string EndVal, string inBetween, string Storedata)
        {
            int IndexPass = 0;
            NumberOfMatches = 0;
            
            string[] words = Storedata.Split(' ');
           
            if (StartVal != null && EndVal.Equals(""))
            { 
                string givenPat = "^"+StartVal+"+"  +"[a-zA-Z0-9]*" + inBetween +"+"+ "[a-zA-Z0-9]*" + @"[a-zA-Z0-9]+$";
                Regex pattern = new Regex(givenPat);
                
                
                foreach (string word in words)
                {
                    
                    MatchCollection miCollection = pattern.Matches(word);

                    foreach (Match match in miCollection)
                    {
                        richTextBox2.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(match.Value+" "+ IndexPass);

                        NumberOfMatches++;
                    }
                    IndexPass += word.Length+1;
                }
            }
            else if (StartVal.Equals("") && EndVal != null)
            {
                string givenPat = "^[a-zA-Z0-9]*" + "[a-zA-Z0-9]*" + inBetween + "+" + "[a-zA-Z0-9]*" + EndVal +"$";
                Regex pattern = new Regex(givenPat);

                
                foreach (string word in words)
                {
                    
                    MatchCollection miCollection = pattern.Matches(word);

                    foreach (Match match in miCollection)
                    {
                        richTextBox2.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(match.Value + " " + IndexPass);

                        NumberOfMatches++;
                    }
                    IndexPass += word.Length+1;
                }
            }
            else if (StartVal.Equals("") && EndVal.Equals("") )
            {


                string givenPat = "^"+StartVal + "+" + "[a-zA-Z0-9]*" + inBetween + "+" + "[a-zA-Z0-9]*" + @"[a-zA-Z0-9]+$";
                Regex pattern = new Regex(givenPat);

                
                foreach (string word in words)
                {
                                          MatchCollection miCollection = pattern.Matches(word);

                    foreach (Match match in miCollection)
                    {
                        richTextBox2.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(match.Value + " " + IndexPass);

                        NumberOfMatches++;
                    }
                    IndexPass += word.Length+1;
                }
            }
            else
            {
                string givenPat = StartVal+"+" + "[a-zA-Z0-9]*" + inBetween + "+" + "[a-zA-Z0-9]*" + EndVal +"+";
                Regex pattern = new Regex(givenPat);

                
                foreach (string word in words)
                {
                    

                    MatchCollection miCollection = pattern.Matches(word);
                    
                    foreach (Match match in miCollection)
                    {
                        
                        richTextBox2.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(match.Value + " " + IndexPass);
                        NumberOfMatches++;
                    }
                    IndexPass += word.Length + 1;
                }
            }

         


        }
        // highlight method that take rich text box and an arraylist which is structured like this(hello 1) first word that we want to hight second is its index 

        void HighLightSearchedText(RichTextBox richText, ArrayList dataToHighlight)
        {   
            for (int i = 0; i < dataToHighlight.Count; i++)
            {
                
                string[] getWord = dataToHighlight[i].ToString().Split(' ');
                
               
                    richText.SelectionStart = Int32.Parse(getWord[1]);
                    richText.SelectionLength = getWord[0].Length;
                    richTextbox1.SelectionBackColor = Color.Yellow;
               
            }
        }
  


    }
}
