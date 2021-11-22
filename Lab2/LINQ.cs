using System.Collections.Generic;
using System.Data;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace Lab2
{
    class LINQ : ISearch
    {
        public List<Professor> Search(Professor Searched, string path)
        {
            List<Professor> ResultProfessorList = new();
            XDocument xDoc = XDocument.Load(path);
            var xProfessorList = from xFaculty in xDoc.Root.Elements()
                                 from xProfessor in xFaculty.Elements()
                                 where (!(Searched.NullProfessor()) &&
                                 (Searched.Name == null || Searched.Name == xProfessor.Attribute("NAME").Value) &&
                                 (Searched.Faculty == null || Searched.Faculty == xProfessor.Parent.Attribute("FACULTY").Value) &&
                                 (Searched.Department == null || Searched.Department == xProfessor.Attribute("DEPARTMENT").Value) &&
                                 (Searched.Section == null || Searched.Section == xProfessor.Attribute("SECTION").Value) &&
                                 (Searched.Cathedra == null || Searched.Cathedra == xProfessor.Attribute("CATHEDRA").Value) &&
                                 (Searched.Proffecion == null || Searched.Proffecion == xProfessor.Attribute("PROFFECION").Value) &&
                                 (Searched.Occupation == null || Searched.Occupation == xProfessor.Attribute("OCCUPATION").Value))
                                 select xProfessor;
            foreach (var xProfessor in xProfessorList)   
            {
                Professor professor = new();
                professor.Name = xProfessor.Attribute("NAME").Value;
                professor.Faculty = xProfessor.Parent.Attribute("FACULTY").Value;
                professor.Department = xProfessor.Attribute("DEPARTMENT").Value;
                professor.Section = xProfessor.Attribute("SECTION").Value;
                professor.Cathedra = xProfessor.Attribute("CATHEDRA").Value;
                professor.Proffecion = xProfessor.Attribute("PROFFECION").Value;
                professor.Occupation = xProfessor.Attribute("OCCUPATION").Value;
                ResultProfessorList.Add(professor);
            }
            return ResultProfessorList;
        }
    }
}
