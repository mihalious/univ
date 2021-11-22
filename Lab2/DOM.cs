using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lab2
{
    class DOM : ISearch
    {
        public List<Professor> Search (Professor Searched, string path)
        {
            List<Professor> ResultProfessorList = new();           
            foreach (Faculty faculty in GetAllProfessorsByFaculties(path))
            {
                foreach (Professor professor in faculty.Professors) 
                {
                    if (professor.Match(Searched)) 
                        ResultProfessorList.Add(professor);
                }
            }
            return ResultProfessorList;
        }

        List<Faculty> GetAllProfessorsByFaculties(string path)
        {
            List<Faculty> FacultyList = new();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlNode root = xDoc.DocumentElement;
            XmlNodeList xFacultyList = root.SelectNodes("Faculty");
            foreach (XmlNode xFaculty in xFacultyList)
            {
                Faculty faculty = new ();
                faculty.FacultyName = xFaculty.Attributes.GetNamedItem("FACULTY").Value;
                XmlNodeList xProfList = xFaculty.SelectNodes("Professor");
                foreach (XmlNode xProfessor in xProfList)
                {                    
                    Professor professor = new();
                    professor.Name = xProfessor.Attributes.GetNamedItem("NAME").Value;
                    professor.Faculty = faculty.FacultyName;
                    professor.Department = xProfessor.Attributes.GetNamedItem("DEPARTMENT").Value;
                    professor.Section = xProfessor.Attributes.GetNamedItem("SECTION").Value;
                    professor.Cathedra = xProfessor.Attributes.GetNamedItem("CATHEDRA").Value;
                    professor.Proffecion = xProfessor.Attributes.GetNamedItem("PROFFECION").Value;
                    professor.Occupation = xProfessor.Attributes.GetNamedItem("OCCUPATION").Value;
                    faculty.AddToFaculty(professor);
                }
                FacultyList.Add(faculty);
            }
            return FacultyList;
        }        
    }

    class Faculty
    {
        string facultyName;
        List<Professor> professors = new();
        public string FacultyName
        {
            get { return facultyName; }
            set { facultyName = value; }
        }
        public List<Professor> Professors
        {
            get { return professors; }
        }
        public void AddToFaculty(Professor professor)
        {
            if (professor.Faculty == facultyName)
                professors.Add(professor);
        }
    }   
}

