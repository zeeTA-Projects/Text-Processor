using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Text_Processor
{
   public partial class TexBox_Components
    {
        private ArrayList importedFiles;    // here we add some sample files into this list.

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

        //UnderLine Function
        public void UnderLine_Function()
        {
            ComponentTexting_Box.SelectionFont = new Font(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.Size, FontStyle.Underline);
        }

        private void Bold_BTN_Click(object sender, EventArgs e)
        {
            Bold_Function();
        }

        //Set Size of Rich TextBOX
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetSize_Function();
        }

        private void FindFilter_BTN_Click(object sender, EventArgs e)
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

        private void ReplaceFilter_BTN_Click(object sender, EventArgs e)
        {
            pnlReplacePanel.Visible = true;
            pnlReplacePanel.BringToFront();
        }

        private void Scrapping_BTN_Click(object sender, EventArgs e)
        {
            pnlScappingPanel.Visible = true;
            pnlScappingPanel.BringToFront();
        }

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

     
    }
}
