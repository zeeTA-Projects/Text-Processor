using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
<<<<<<< Updated upstream
=======
using System.Text.RegularExpressions;
using IronOcr;
using System.Speech.Synthesis;
using System.Diagnostics;
>>>>>>> Stashed changes

namespace Text_Processor
{
   public partial class TexBox_Components
    {
        private ArrayList importedFiles;    // here we add some sample files into this list.
<<<<<<< Updated upstream
=======
        static ArrayList storeSearchData;
        static ArrayList storeScrappingFiles;
        static int NumberOfMatches=0;


        // form event  
        //here we make filter panels invisible
        private void TexBox_Components_Load(object sender, EventArgs e)
        {

            pnlFindPanel.Visible = false;
            pnlSearchPanel.Visible = false;
            pnlScappingPanel.Visible = false;
            pnlReplacePanel.Visible = false;
            pnlReadData.Visible = false;

            pnlSearchPanel.Location = new Point(572, 134);
            pnlFindPanel.Location = new Point(572, 134); ;
            pnlReplacePanel.Location = new Point(572, 134);
            pnlScappingPanel.Location = new Point(572, 134); ;
            pnlReadData.Location = new Point(572, 134);
            AddFileToListbox_function(listBox1,importedFiles); //method that add arraylist of file name in listbox 

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
>>>>>>> Stashed changes

        /**
         * Every thing is perfect .
         * Couple of things which you need to follow.
         * What ever you need to declare, declare in this class.
         * And try to create cohesive methods if possible.
         * An other thing is that of you are applying option
         * like bold or italic or any thing then pass the selected txt
         * from parameter.
         * An other thing re arrange code a bit, in a way that  Listner methods should be above and
         * your deifined methods should be after them ...
         * 
         * 
         * 
         * Rest of thing thing is wonderfull as i expected.
         */


        //Bold Function
        private void UnderLine_BTN_Click(object sender, EventArgs e)
        {
            UnderLine_Function();
        }

        private void pnlGeneralOptions_Paint(object sender, PaintEventArgs e)
        {
            //on program load this set visble false of option panels.
         
        }
<<<<<<< Updated upstream
        public void Bold_Function()
        {
            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Bold);
        }

        //HighLight Function
        public void HighLight_Function()
        {
            ComponentTexting_Box.SelectionBackColor = Color.Yellow;
        }

        // Italic Function
        public void Italic_Function()
=======
        
        //Main Window listBox shows some file name to select
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox1,richTextbox1); //with this we can select any file that will open in richtextBox
        }

        //******************************************************************************************************************


          
        // these are fnction that we are calling in above events 
        // this bold function, will call in bold button to set text of richtextbox bold
        public void Bold_Function(RichTextBox richTextbox_text_processor)
>>>>>>> Stashed changes
        {
            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Italic);
        }

        public void SearchFilter_Function()
        {
           
        }

        //Search Filter Function
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

<<<<<<< Updated upstream
=======

        // there function are passed to to combo box event to get selected value from combo box and edit rich text box according to that
>>>>>>> Stashed changes
        //font type  Set Functions
        public void SetFont_Function()
        {
            string Font = SetFont_box.SelectedItem.ToString();
            ComponentTexting_Box.SelectionFont = new Font(Font, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
        }


        //Text size Set Function
        public void SetSize_Function()
        {
            if (comboBox1.SelectedItem != null)
            {
                int size = Int32.Parse(comboBox1.SelectedItem.ToString());
                ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, size, SystemFonts.DefaultFont.Style);
            }
            else
            {
                ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, SystemFonts.DefaultFont.Style);
            }
        }

<<<<<<< Updated upstream
        //UnderLine Function
        public void UnderLine_Function()
        {
            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Underline);
=======

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

            AddFileToListbox_function(Listbox_findFilter,importedFiles);
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
            Search1_FindFilter_function(Start_FindFilter_txt.Text,End_FindFilter_txt.Text,richTextbox1.Text,richTextBox2);
        }

        // this event take first and last value as well as any value between them from textBox and filters all related value from richtextbox
        private void Search2_FindFilter_btn_Click(object sender, EventArgs e)
        {
            if (!(Contain_FindFilter_txt.Text.Equals("")))
            {
                storeSearchData.Clear(); 
                richTextBox2.Clear();
                Search2_FindFilter_function(Start_FindFilter_txt.Text, End_FindFilter_txt.Text, Contain_FindFilter_txt.Text, richTextbox1.Text,richTextBox2);
            }
            else
            {
            }
        }
       

        // in this we hightlight searched word of richTextbox
        private void HighLight_FindFilter_btn_Click(object sender, EventArgs e)
        {

            HighLightSearchedText(richTextbox1,storeSearchData);


>>>>>>> Stashed changes
        }
        //***********************************FIND FILTER CODE ENDS HERE*****************************************************




        private void Bold_BTN_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            Bold_Function();
        }

        //Set Size of Rich TextBOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSize_Function();
        }

        private void FindFilter_BTN_Click(object sender, EventArgs e)
=======
            pnlSearchPanel.Visible = true;
            pnlSearchPanel.BringToFront();
            AddFileToListbox_function(listBox2,importedFiles);
        }

        //Listbox selecting any available file
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox2,richTextbox1);
        }


        //This will browse any file given in a text file if its available
        private void Browse_searchFilter_btn_Click(object sender, EventArgs e)
>>>>>>> Stashed changes
        {
            pnlFindPanel.Visible = true;
            pnlFindPanel.BringToFront();

            
        }

        private void HighLight_BTN_Click(object sender, EventArgs e)
        {
            HighLight_Function();
        }

        private void Italic_BTN_Click(object sender, EventArgs e)
        {
            Italic_Function();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function();
        }

<<<<<<< Updated upstream
=======
        //******************** SEARCH FILTER ENDS HERE************************************************************


        /**
         * from here replace filter starts
         * **/


        //calling panel of replace filter
>>>>>>> Stashed changes
        private void ReplaceFilter_BTN_Click(object sender, EventArgs e)
        {
            pnlReplacePanel.Visible = true;
            pnlReplacePanel.BringToFront();
<<<<<<< Updated upstream
        }

=======
            AddFileToListbox_function(listBox7,importedFiles);  // add array of files name in to listbox
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
            Search1_FindFilter_function(start_ReplaceFilter_txt.Text,end_ReplaceFilter_txt.Text, richTextbox1.Text,richTextBox2);
        }


        // search for first ,last and in between occurrence of any character in word
        private void search2_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {   if (!(Contain_FindFilter_txt.Text.Equals("")))
            {
                storeSearchData.Clear();
                richTextBox2.Clear();
                Search2_FindFilter_function(start_ReplaceFilter_txt.Text, end_ReplaceFilter_txt.Text, Contain_FindFilter_txt.Text, richTextbox1.Text,richTextBox2); }
            else { 
            
            }
        }

        // will replace searched with given text 
        private void Replace_ReplaceFilter_btn_Click(object sender, EventArgs e)
        {
            ReplaceSearchWord_Function(richTextbox1,storeSearchData,ReplaceWith_ReplaceFilter_txt.Text);
        }

        //method for replace 
        void ReplaceSearchWord_Function(RichTextBox richText, ArrayList ReplaceWord,string WordForReplace) {
            foreach(storeSearchData storeData in ReplaceWord)
            {
                richTextbox1.Text = richText.Text.Replace(storeData.FoundWord, WordForReplace);
            }
        }




        /**
         * from here scrapping filter starts   *****************************************************************
         * **/


>>>>>>> Stashed changes
        private void Scrapping_BTN_Click(object sender, EventArgs e)
        {
            pnlScappingPanel.Visible = true;
            pnlScappingPanel.BringToFront();
            AddFileToListbox_function(ListBox_AvailableFile_scrapping,importedFiles);  // add array of files name in to listbox

        }

        // Events Are Here
        
        private void Browse_ScrappingBtn_Click(object sender, EventArgs e)
        {   string ImportFileType= "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            ImportFile_Function(ListBox_SelectedFile_scrapping, ImportFileType);
        }

        //****  Remove from selected list box
        private void Remove_ScrappingBtn_Click(object sender, EventArgs e)
        {
            RemoveFileFrom_Listbox_Function(ListBox_SelectedFile_scrapping);
        }

        //*********** add from first list to second (available to selected)
        private void Add_ScrappingBtn_Click(object sender, EventArgs e)
        {
            AddSelectedFiles_To_File_Function(ListBox_AvailableFile_scrapping,ListBox_SelectedFile_scrapping);
        }

        //*****************  all selected files
        private void ListBox_SelectedFile_scrapping_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileFrom_listBox_Function(ListBox_SelectedFile_scrapping);// method to open
        }

        // search from multiple files
        private void Search_ScrappingBtn_Click(object sender, EventArgs e)
        {
            storeSearchData.Clear();
            Search_scrapping_Function(StartSearch_Scrapping_Txt.Text,EndSearch_Scrapping_Txt.Text,ContainSearch_Scrapping_Txt.Text,ListBox_SelectedFile_scrapping);
        }


        // replace from multiple files
        private void Replace_ScrappingBtn_Click(object sender, EventArgs e)
        {
            Replace_inFile_scrapping_Function(ListBox_Founded_Files_Scrapping, storeSearchData, ReplaceSearch_Scrapping_Txt.Text);
        }

<<<<<<< Updated upstream
        private void Search_Filter_BTN_Click(object sender, EventArgs e)
        {
            pnlSearchPanel.Visible = true;
            pnlSearchPanel.BringToFront();
        }

        //set font style of richTextBox
        private void SetFont_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFont_Function();
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


            foreach (string fileName in importedFiles)
            {
                listBox1.Items.Add(fileName);  // adding files from array to list box
            }
        }

     
=======
        private void Result_ScrappingBtn_Click(object sender, EventArgs e)
        {
            AddFileToListbox_function(ListBox_Founded_Files_Scrapping,storeScrappingFiles);
        }


        //******** Files as a result of search
        private void ListBox_Founded_Files_Scrapping_SelectedIndexChanged(object sender, EventArgs e)
        {
            OpenFileFrom_listBox_Function(ListBox_Founded_Files_Scrapping);
        }


        //************************* Methods
        //***************** Method to Add selected files to selected listBox
        void AddSelectedFiles_To_File_Function(ListBox listBox1, ListBox listBox2)
        {
            
            foreach (FileInfoDataHolder SelectedFileName in listBox1.SelectedItems)  // get each selected item
            {
                //Now open file and print its data to rich text box
                FileInfo fi = new FileInfo(SelectedFileName.fileFullName);
                if (fi.Exists)
                {
                    listBox2.Items.Add(new FileInfoDataHolder(SelectedFileName.fileSafeName, SelectedFileName.fileFullName,0,null)); ;
                }
            }
        }


        //******** REmove method to remove files from list box
        void RemoveFileFrom_Listbox_Function(ListBox listBox) {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBox);
            selectedItems = listBox.SelectedItems;

            if (listBox.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                    listBox.Items.Remove(selectedItems[i]);
            }
            else
                MessageBox.Show("please select a file first");
        }

        //***************** Function to open selected listbox file 
        void OpenFileFrom_listBox_Function(ListBox listBox) {
            FileInfoDataHolder storeData= listBox.SelectedItem as FileInfoDataHolder;
           
            var fileToOpen = storeData.fileFullName;
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();
            process.WaitForExit();
        }
        //*********************************** Search Method from each file
        void Search_scrapping_Function(string StartVal,string EndVal,string inBetween,ListBox listBox) {

            Boolean found;
            if (!(StartVal.Equals("") && EndVal.Equals("") && inBetween.Equals("")))
            {  
                // taking files from listbox one by one then searching apply on it
                foreach (FileInfoDataHolder file in listBox.Items)
                {
                    found = false;
                    string EachFile_Data = "";
                    FileInfo fi = new FileInfo(file.fileFullName);
                    if (fi.Exists)
                    {
                        using (StreamReader readFile = fi.OpenText())
                        {
                            string readData = "";
                            while ((readData = readFile.ReadLine()) != null)
                            {
                                EachFile_Data += readData;
                            }

                            // from here code for searching starts
                            int IndexPass = 0;
                            string[] words = EachFile_Data.Split(' ');

                            string givenPat = StartVal + "+" + "[a-zA-Z0-9]*" + inBetween + "+" + "[a-zA-Z0-9]*" + EndVal + "+";
                            Regex pattern = new Regex(givenPat);

                            richTextBox2.Text += "from file " + fi.Name + "\n";
                            foreach (string word in words)
                            {


                                MatchCollection miCollection = pattern.Matches(word);

                                foreach (Match match in miCollection)
                                {
                                    if (match.Success) {
                                        found = true;
                                    }
                                  
                                    storeSearchData.Add(new storeSearchData(match.Value, IndexPass, match.Length)); //use this for highlight and replace function
                                    NumberOfMatches++;
                                }
                                IndexPass += word.Length + 1;
                            }
                            if (found)
                            {
                                storeScrappingFiles.Add(new FileInfoDataHolder(fi.Name,fi.FullName,fi.Length,null));
                            }
                        }
                    }
                }


            }
            else {
                MessageBox.Show("Please Enter Value first to Search");
            }
        }


        //*************************  Replace from file in scrapping

        void Replace_inFile_scrapping_Function(ListBox listBox,ArrayList ReplaceWord,string WordForReplace) {
           
           foreach (FileInfoDataHolder fi in listBox.Items)
            {
                FileInfo file = new FileInfo(fi.fileFullName);
                string dataToStore = "";
                if (file.Exists)
                {
                   
                    using (StreamReader readFile = file.OpenText())
                    {
                        string readData = "";
                        while ((readData = readFile.ReadLine()) != null)

                        { dataToStore += readData; }

                    }

                    foreach (storeSearchData storeData in ReplaceWord)
                    {
                        dataToStore = dataToStore.Replace(storeData.FoundWord, WordForReplace);
                    }
                    using (StreamWriter sw = new StreamWriter(file.FullName, false))
                    {
                        sw.Write(dataToStore);
                        MessageBox.Show("Done");
                    }

                }
               
            }
        }





        /**
         * from here read filter starts
         * **/


        private void Read_Data_btn_Click(object sender, EventArgs e)
        {
            pnlReadData.Visible = true;
            pnlReadData.BringToFront();
        }


        // REad  from Image 

        //********************************* Events **********************
        
        // this will import images intoo listbox
        private void Import_Image_btn_Click(object sender, EventArgs e)
        {
            string ImportFileType = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ImportFile_Function(listBox_import_images, ImportFileType);
        }


        // Listbox to show all image name which add in it
        private void listBox_import_images_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selected_image_to_Display(listBox_import_images);
        }


        // event to read Image
        private void ReadImage_btn_Click(object sender, EventArgs e)
        {
           string ImageName = listBox_import_images.SelectedItem.ToString();
            ReadDataFRomImage_Function(ImageName, ImageData_box);
        }

        //******************** Method To call*************************************


        //Method to selected images from listbox and show in picture box
        void Selected_image_to_Display(ListBox listBox) {
            string imageLocation=listBox.SelectedItem.ToString();
            ImagesToRead_box.ImageLocation = imageLocation;
        }

        // Method to read Data fromImage 
        void ReadDataFRomImage_Function(string ImageName,RichTextBox richTextBox) {
            var Ocr=new IronTesseract();
            using (var ocr = new OcrInput(ImageName))
            {
                richTextBox.Text = Ocr.Read(ocr).ToString();
            }
        }


        //================
        // Read from file Aloud here

        // this will import file and store that to listbox
        private void Import_File_btn_Click(object sender, EventArgs e)
        {  string ImportFileType= "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
            ImportFile_Function(listBox_import_images, ImportFileType);
        }

        // event to select file from listbox
        private void listBox_readFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            Select_File_To_Open_Function(listBox_readFiles, ShowFileToRead_box);
        }

        private void Read_Aloud_btn_Click(object sender, EventArgs e)
        {
            MethodToReadData_inVoice(ShowFileToRead_box);
        }


        // REad aloud mEthod*************************************
     
        //Method To read Aloud
        void MethodToReadData_inVoice(RichTextBox richText) {
            SpeechSynthesizer ss = new SpeechSynthesizer();
            ss.Rate = -2;
            ss.Volume = 60;
            ss.SpeakAsync(richText.Text);
        }



        //*********************************  these functions are called in more than one events

        //Browse button which take filename and get its text if file is availaibe
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
        void AddFileToListbox_function(ListBox listBox,ArrayList filesImported)
        {
            listBox.Items.Clear();
            foreach (FileInfoDataHolder file in filesImported)
            {
                listBox.Items.Add(file);  // adding files from array to list box
            }
        }


        // select one or multiple file to open in rich text box
        // this function will call at list box selected listener
        // this function would be call many time 

        public void Select_File_To_Open_Function(ListBox listBox,RichTextBox richText)
        {
              listBox.SelectionMode= System.Windows.Forms.SelectionMode.MultiSimple;

            foreach (FileInfoDataHolder SelectedFileName in listBox.SelectedItems)  // get each selected item
            {
                //Now open file and print its data to rich text box
                FileInfo fi = new FileInfo(SelectedFileName.fileFullName);
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


        //Method to import File in listbox
        void ImportFile_Function(ListBox listBox, string ImportFileType)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "\\C:";
            op.Filter = ImportFileType;
            op.Multiselect = true;
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int i = 0;
                    foreach (string file in op.FileNames)
                    {

                        listBox.Items.Add(new FileInfoDataHolder(op.SafeFileNames[i], file, 0, null));
                        i++;
                    }

                }
                catch (Exception ex) { }

            }
        }




        // funtions that use for search in (replace and find filters)


        //Search Function for find filter command
        // for that we take two values from users 1. start and 2. end
        void Search1_FindFilter_function(string StartVal, string EndVal,string Storedata,RichTextBox richTextBox)
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
                       richTextBox.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(new storeSearchData(match.Value, IndexPass, match.Length));

                        NumberOfMatches++;
                    }
                    IndexPass += word.Length+1;
                }
            }



        }

        //Search2 Function for find filter command
        // for that we take a which find filter for in between 
        void Search2_FindFilter_function(string StartVal, string EndVal, string inBetween, string Storedata,RichTextBox richTextBox)
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
                        richTextBox.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(new storeSearchData(match.Value, IndexPass, match.Length));

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
                        richTextBox.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(new storeSearchData(match.Value, IndexPass, match.Length));

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
                        richTextBox.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(new storeSearchData(match.Value, IndexPass, match.Length));

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
                        
                        richTextBox.Text += String.Format(match.Value + "\n ");
                        storeSearchData.Add(new storeSearchData(match.Value, IndexPass, match.Length));
                        NumberOfMatches++;
                    }
                    IndexPass += word.Length + 1;
                }
            }

         


        }
        // highlight method that take rich text box and an arraylist which is structured like this(hello 1) first word that we want to hight second is its index 

        void HighLightSearchedText(RichTextBox richText,ArrayList dataToHighlight)
        {
            foreach (storeSearchData searchData in dataToHighlight)
            {
                richText.SelectionStart = searchData.Found_Word_index;
                richText.SelectionLength = searchData.foundWord_length;
                richText.SelectionBackColor = Color.Yellow;
            }
           
        }
>>>>>>> Stashed changes
    }
}
