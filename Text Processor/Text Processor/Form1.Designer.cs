namespace Text_Processor
{
    partial class TexBox_Components
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.ReplaceFilter_BTN = new System.Windows.Forms.Button();
            this.FindFilter_BTN = new System.Windows.Forms.Button();
            this.Search_Filter_BTN = new System.Windows.Forms.Button();
            this.Scrapping_BTN = new System.Windows.Forms.Button();
            this.HighLight_BTN = new System.Windows.Forms.Button();
            this.Font = new System.Windows.Forms.Label();
            this.SetFont_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.UnderLine_BTN = new System.Windows.Forms.Button();
            this.Italic_BTN = new System.Windows.Forms.Button();
            this.Bold_BTN = new System.Windows.Forms.Button();
            this.ComponentTexting_Box = new System.Windows.Forms.RichTextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Read_Data_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Read_Data_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ReplaceFilter_BTN);
            this.panel1.Controls.Add(this.FindFilter_BTN);
            this.panel1.Controls.Add(this.Search_Filter_BTN);
            this.panel1.Controls.Add(this.Scrapping_BTN);
            this.panel1.Controls.Add(this.HighLight_BTN);
            this.panel1.Controls.Add(this.Font);
            this.panel1.Controls.Add(this.SetFont_box);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.UnderLine_BTN);
            this.panel1.Controls.Add(this.Italic_BTN);
            this.panel1.Controls.Add(this.Bold_BTN);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 99);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(768, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 66);
            this.label2.TabIndex = 12;
            this.label2.Text = "This will show results of diff options\r\n";
            // 
            // ReplaceFilter_BTN
            // 
            this.ReplaceFilter_BTN.Location = new System.Drawing.Point(490, 59);
            this.ReplaceFilter_BTN.Name = "ReplaceFilter_BTN";
            this.ReplaceFilter_BTN.Size = new System.Drawing.Size(120, 23);
            this.ReplaceFilter_BTN.TabIndex = 11;
            this.ReplaceFilter_BTN.Text = "Replace Filters";
            this.ReplaceFilter_BTN.UseVisualStyleBackColor = true;
            this.ReplaceFilter_BTN.Click += new System.EventHandler(this.ReplaceFilter_BTN_Click);
            // 
            // FindFilter_BTN
            // 
            this.FindFilter_BTN.Location = new System.Drawing.Point(490, 16);
            this.FindFilter_BTN.Name = "FindFilter_BTN";
            this.FindFilter_BTN.Size = new System.Drawing.Size(120, 23);
            this.FindFilter_BTN.TabIndex = 10;
            this.FindFilter_BTN.Text = "Find Filters";
            this.FindFilter_BTN.UseVisualStyleBackColor = true;
            this.FindFilter_BTN.Click += new System.EventHandler(this.FindFilter_BTN_Click);
            // 
            // Search_Filter_BTN
            // 
            this.Search_Filter_BTN.Location = new System.Drawing.Point(354, 16);
            this.Search_Filter_BTN.Name = "Search_Filter_BTN";
            this.Search_Filter_BTN.Size = new System.Drawing.Size(120, 23);
            this.Search_Filter_BTN.TabIndex = 9;
            this.Search_Filter_BTN.Text = "Search Filters";
            this.Search_Filter_BTN.UseVisualStyleBackColor = true;
            this.Search_Filter_BTN.Click += new System.EventHandler(this.Search_Filter_BTN_Click);
            // 
            // Scrapping_BTN
            // 
            this.Scrapping_BTN.Location = new System.Drawing.Point(354, 59);
            this.Scrapping_BTN.Name = "Scrapping_BTN";
            this.Scrapping_BTN.Size = new System.Drawing.Size(120, 23);
            this.Scrapping_BTN.TabIndex = 8;
            this.Scrapping_BTN.Text = "Scraping";
            this.Scrapping_BTN.UseVisualStyleBackColor = true;
            this.Scrapping_BTN.Click += new System.EventHandler(this.Scrapping_BTN_Click);
            // 
            // HighLight_BTN
            // 
            this.HighLight_BTN.Location = new System.Drawing.Point(256, 16);
            this.HighLight_BTN.Name = "HighLight_BTN";
            this.HighLight_BTN.Size = new System.Drawing.Size(75, 23);
            this.HighLight_BTN.TabIndex = 7;
            this.HighLight_BTN.Text = "High Light";
            this.HighLight_BTN.UseVisualStyleBackColor = true;
            this.HighLight_BTN.Click += new System.EventHandler(this.HighLight_BTN_Click);
            // 
            // Font
            // 
            this.Font.AutoSize = true;
            this.Font.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Font.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Font.Location = new System.Drawing.Point(143, 57);
            this.Font.Name = "Font";
            this.Font.Size = new System.Drawing.Size(36, 17);
            this.Font.TabIndex = 6;
            this.Font.Text = "Font";
            // 
            // SetFont_box
            // 
            this.SetFont_box.AutoCompleteCustomSource.AddRange(new string[] {
            "You will put all usefull font family"});
            this.SetFont_box.FormattingEnabled = true;
            this.SetFont_box.Items.AddRange(new object[] {
            "Calibri Light",
            "Georgia",
            "Informal Roman",
            "Freestyle Script",
            "Arial Black",
            "Brush Script MT",
            "Times New Roman"});
            this.SetFont_box.Location = new System.Drawing.Point(191, 57);
            this.SetFont_box.Name = "SetFont_box";
            this.SetFont_box.Size = new System.Drawing.Size(90, 21);
            this.SetFont_box.TabIndex = 5;
            this.SetFont_box.SelectedIndexChanged += new System.EventHandler(this.SetFont_box_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Size";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "40",
            "48"});
            this.comboBox1.Location = new System.Drawing.Point(83, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(54, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // UnderLine_BTN
            // 
            this.UnderLine_BTN.Location = new System.Drawing.Point(175, 16);
            this.UnderLine_BTN.Name = "UnderLine_BTN";
            this.UnderLine_BTN.Size = new System.Drawing.Size(75, 23);
            this.UnderLine_BTN.TabIndex = 2;
            this.UnderLine_BTN.Text = "Under Line";
            this.UnderLine_BTN.UseVisualStyleBackColor = true;
            this.UnderLine_BTN.Click += new System.EventHandler(this.UnderLine_BTN_Click);
            // 
            // Italic_BTN
            // 
            this.Italic_BTN.Location = new System.Drawing.Point(94, 16);
            this.Italic_BTN.Name = "Italic_BTN";
            this.Italic_BTN.Size = new System.Drawing.Size(75, 23);
            this.Italic_BTN.TabIndex = 1;
            this.Italic_BTN.Text = "Italic";
            this.Italic_BTN.UseVisualStyleBackColor = true;
            this.Italic_BTN.Click += new System.EventHandler(this.Italic_BTN_Click);
            // 
            // Bold_BTN
            // 
            this.Bold_BTN.Location = new System.Drawing.Point(13, 16);
            this.Bold_BTN.Name = "Bold_BTN";
            this.Bold_BTN.Size = new System.Drawing.Size(75, 23);
            this.Bold_BTN.TabIndex = 0;
            this.Bold_BTN.Text = "Bold";
            this.Bold_BTN.UseVisualStyleBackColor = true;
            this.Bold_BTN.Click += new System.EventHandler(this.Bold_BTN_Click);
            // 
            // ComponentTexting_Box
            // 
            this.ComponentTexting_Box.Location = new System.Drawing.Point(25, 136);
            this.ComponentTexting_Box.Name = "ComponentTexting_Box";
            this.ComponentTexting_Box.Size = new System.Drawing.Size(627, 289);
            this.ComponentTexting_Box.TabIndex = 1;
            this.ComponentTexting_Box.Text = "";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(670, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(242, 290);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Read_Data_btn
            // 
            this.Read_Data_btn.Location = new System.Drawing.Point(632, 16);
            this.Read_Data_btn.Name = "Read_Data_btn";
            this.Read_Data_btn.Size = new System.Drawing.Size(120, 23);
            this.Read_Data_btn.TabIndex = 13;
            this.Read_Data_btn.Text = "Read Data";
            this.Read_Data_btn.UseVisualStyleBackColor = true;
            // 
            // TexBox_Components
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ComponentTexting_Box);
            this.Controls.Add(this.panel1);
            this.Name = "TexBox_Components";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TexBox_Components_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ReplaceFilter_BTN;
        private System.Windows.Forms.Button FindFilter_BTN;
        private System.Windows.Forms.Button Search_Filter_BTN;
        private System.Windows.Forms.Button Scrapping_BTN;
        private System.Windows.Forms.Button HighLight_BTN;
        private System.Windows.Forms.Label Font;
        private System.Windows.Forms.ComboBox SetFont_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button UnderLine_BTN;
        private System.Windows.Forms.Button Italic_BTN;
        private System.Windows.Forms.Button Bold_BTN;
        private System.Windows.Forms.RichTextBox ComponentTexting_Box;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button Read_Data_btn;
    }
}

