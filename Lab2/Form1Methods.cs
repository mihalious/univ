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
using System.Xml.Xsl;



namespace Lab2
{
    public partial class Form1 : Form
    {
        private string path = @"C:\University\Visual studio\Lab2\Professors.xml"; 
        public string Path
        {
            get { return path; }
            set { path = value; }
        }
        void LoadPofsToForm(string path)
        {            
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);           
            XmlNode root = xDoc.DocumentElement;
            XmlNodeList xFacultyList = root.SelectNodes("Faculty");
            foreach (XmlNode xFaculty in xFacultyList)
            {
                ComboBoxFaculty.Items.Add(xFaculty.Attributes.GetNamedItem("FACULTY").Value);
                XmlNodeList xProfList = xFaculty.SelectNodes("Professor");
                foreach (XmlNode xProfessor in xProfList)
                {
                    ComboBoxName.Items.Add(xProfessor.Attributes.GetNamedItem("NAME").Value);
                    ComboBoxDepartment.Items.Add(xProfessor.Attributes.GetNamedItem("DEPARTMENT").Value);
                    ComboBoxSection.Items.Add(xProfessor.Attributes.GetNamedItem("SECTION").Value);
                    ComboBoxCathedra.Items.Add(xProfessor.Attributes.GetNamedItem("CATHEDRA").Value);
                    ComboBoxProffecion.Items.Add(xProfessor.Attributes.GetNamedItem("PROFFECION").Value);
                    ComboBoxOccupation.Items.Add(xProfessor.Attributes.GetNamedItem("OCCUPATION").Value);
                }
            }
        }

        public Professor SearchedProfessor()
        {
            Professor professor = new();            
            if (checkBoxName.Checked && !(ComboBoxName.Text == ""))
                professor.Name = ComboBoxName.Text;
            if (checkBoxFaculty.Checked && !(ComboBoxFaculty.Text == ""))
                professor.Faculty = ComboBoxFaculty.Text;
            if (checkBoxDepartment.Checked && !(ComboBoxDepartment.Text == ""))
                professor.Department = ComboBoxDepartment.Text;
            if (checkBoxSection.Checked && !(ComboBoxSection.Text == ""))
                professor.Section = ComboBoxSection.Text;
            if (checkBoxCathedra.Checked && !(ComboBoxCathedra.Text == ""))
                professor.Cathedra = ComboBoxCathedra.Text;
            if (checkBoxProffecion.Checked && !(ComboBoxProffecion.Text == ""))
                professor.Proffecion = ComboBoxProffecion.Text;
            if (checkBoxOccupation.Checked && !(ComboBoxOccupation.Text == ""))
                professor.Occupation = ComboBoxOccupation.Text;
            return professor;
        }

        public void Output (List<Professor> professorList)
        {
            foreach(Professor professor in professorList)
            {
                OutputTextBox.Text+= ("Name: " + professor.Name + '\n');
                OutputTextBox.Text += ("Faculty: " + professor.Faculty + '\n');
                OutputTextBox.Text += ("Department: " + professor.Department + '\n');
                OutputTextBox.Text += ("Section: " + professor.Section + '\n');
                OutputTextBox.Text += ("Cathedra: " + professor.Cathedra + '\n');
                OutputTextBox.Text += ("Proffecion: " + professor.Proffecion + '\n');
                OutputTextBox.Text += ("Occupation: " + professor.Occupation + '\n');
                OutputTextBox.Text += '\n';
            }
        }

        public void Output(Professor professor)
        {
            OutputTextBox.Text += ("Name: " + professor.Name + '\n');
            OutputTextBox.Text += ("Faculty: " + professor.Faculty + '\n');
            OutputTextBox.Text += ("Department: " + professor.Department + '\n');
            OutputTextBox.Text += ("Section: " + professor.Section + '\n');
            OutputTextBox.Text += ("Cathedra: " + professor.Cathedra + '\n');
            OutputTextBox.Text += ("Proffecion: " + professor.Proffecion + '\n');
            OutputTextBox.Text += ("Occupation: " + professor.Occupation + '\n');
            OutputTextBox.Text += '\n';
        }

        bool NoParametrCheked()
        {
            if (!checkBoxName.Checked &&
                !checkBoxFaculty.Checked &&
                !checkBoxDepartment.Checked &&
                !checkBoxSection.Checked &&
                !checkBoxCathedra.Checked &
                !checkBoxProffecion.Checked &&
                !checkBoxOccupation.Checked)
            {
                OutputTextBox.Clear();
                MessageBox.Show("Select at least one parameter to search");
                return true;
            }
            else return false;
        }

        bool NoValueSelected()
        {
            if (ComboBoxName.Text == "" &&
                ComboBoxFaculty.Text == "" &&
                ComboBoxDepartment.Text == "" &&
                ComboBoxSection.Text == "" &&
                ComboBoxCathedra.Text == "" &&
                ComboBoxProffecion.Text == "" &&
                ComboBoxOccupation.Text == "")
            {
                OutputTextBox.Clear();
                MessageBox.Show("Select at least one value to compare");
                return true;
            }              
            else return false;
        }    

        bool NoMathch()
        {
            if ((!checkBoxName.Checked || ComboBoxName.Text == "") &&
                (!checkBoxFaculty.Checked || ComboBoxFaculty.Text == "") &&
                (!checkBoxDepartment.Checked || ComboBoxDepartment.Text == "") &&
                (!checkBoxSection.Checked || ComboBoxSection.Text == "") &&
                (!checkBoxCathedra.Checked || ComboBoxCathedra.Text == "") &&
                (!checkBoxProffecion.Checked || ComboBoxProffecion.Text == "") &&
                (!checkBoxOccupation.Checked || ComboBoxOccupation.Text == ""))
            {
                OutputTextBox.Clear();
                MessageBox.Show("Parameters and values dont match");
                return true;
            }
            else return false;                
        }

        public void DefaultOutput(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlNode root = xDoc.DocumentElement;
            XmlNodeList xFacultyList = root.SelectNodes("Faculty");
            foreach (XmlNode xFaculty in xFacultyList)
            {
                XmlNodeList xProfList = xFaculty.SelectNodes("Professor");
                foreach (XmlNode xProfessor in xProfList)
                {
                    Professor professor = new();
                    professor.Name = xProfessor.Attributes.GetNamedItem("NAME").Value;
                    if (professor.Faculty != xProfessor.ParentNode.Attributes.GetNamedItem("FACULTY").Value)
                    {
                        professor.Faculty = xProfessor.ParentNode.Attributes.GetNamedItem("FACULTY").Value;
                    }
                    professor.Department = xProfessor.Attributes.GetNamedItem("DEPARTMENT").Value;
                    professor.Section = xProfessor.Attributes.GetNamedItem("SECTION").Value;
                    professor.Cathedra = xProfessor.Attributes.GetNamedItem("CATHEDRA").Value;
                    professor.Proffecion = xProfessor.Attributes.GetNamedItem("PROFFECION").Value;
                    professor.Occupation = xProfessor.Attributes.GetNamedItem("OCCUPATION").Value;
                    Output(professor);
                }
            }
        }

        public void ClearForm()
        {
            OutputTextBox.Clear();
            checkBoxName.Checked = false;
            checkBoxFaculty.Checked = false;
            checkBoxDepartment.Checked = false;
            checkBoxSection.Checked = false;
            checkBoxCathedra.Checked = false;
            checkBoxProffecion.Checked = false;
            checkBoxOccupation.Checked = false;
            RadioButtonSAX.Checked = false;
            RadioButtonDOM.Checked = false;
            RadioButtonLINQ.Checked = false;
            ComboBoxName.Text = null;
            ComboBoxFaculty.Text = null;
            ComboBoxDepartment.Text = null;
            ComboBoxSection.Text = null;
            ComboBoxCathedra.Text = null;
            ComboBoxProffecion.Text = null;
            ComboBoxOccupation.Text = null;
        }

        public void ClearComboBox()
        {
            ComboBoxName.Items.Clear();
            ComboBoxFaculty.Items.Clear();
            ComboBoxDepartment.Items.Clear();
            ComboBoxSection.Items.Clear();
            ComboBoxCathedra.Items.Clear();
            ComboBoxProffecion.Items.Clear();
            ComboBoxOccupation.Items.Clear();
        }

        void OpenFile()
        {
            OpenFileDialog openFileDialog = new();
            openFileDialog.Filter = "XML Files |*.xml";
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            Path = openFileDialog.FileName;
            ClearForm();
            ClearComboBox();
            LoadPofsToForm(Path);
            DefaultOutput(Path);
        }

    }
    
}