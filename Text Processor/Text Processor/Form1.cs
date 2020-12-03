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
namespace Text_Processor
{
    public partial class Form1 : Form
    {
        ArrayList importedFiles;
        public Form1()
        {
            InitializeComponent();

            importedFiles = new ArrayList();
            
            // You will add some sample files into this list.
        }
    }
}
