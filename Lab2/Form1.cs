using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Xsl;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadPofsToForm(Path);
            DefaultOutput(Path);
        }


        private void RadioButtonSAX_CheckedChanged(object sender, EventArgs e)
        {
            
        }    
        
        
        private void RadioButtonDOM_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonLINQ_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void OutputTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (!NoParametrCheked() && !NoValueSelected() && !NoMathch())
            {
                if (RadioButtonLINQ.Checked)
                {
                    OutputTextBox.Clear();
                    ISearch search = new LINQ();                    
                    Output(search.Search(SearchedProfessor(), Path));
                }
                else
                    if (RadioButtonDOM.Checked)
                {
                    OutputTextBox.Clear();
                    ISearch search = new DOM();
                    Output(search.Search(SearchedProfessor(), Path));
                }
                else
                    if (RadioButtonSAX.Checked)
                {
                    OutputTextBox.Clear();
                    ISearch search = new SAX();
                    Output(search.Search(SearchedProfessor(), Path));
                }
                else MessageBox.Show("Select search method");
            }
        }


        private void ToHtmlButton_Click(object sender, EventArgs e)
        {
            XslCompiledTransform xslt = new();
            string xslPath = @"C:\University\Visual studio\Lab2\XSLTFile1.xslt";
            xslt.Load(xslPath);
            string result = @"Professors.html";
            xslt.Transform(Path, result);
            MessageBox.Show("File saved");
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }      

        private void ComboBoxName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        private void ComboBoxFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ComboBoxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxCathedra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        

        private void ComboBoxProffecion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ComboBoxOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }     
        
        private void checkBoxName_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxFaculty_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxDepartment_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxSection_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxCathedra_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxProffecion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxOccupation_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new();
            about.ShowDialog();
        }

        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        
    }


   
}
