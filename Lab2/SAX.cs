using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Lab2
{
    class SAX : ISearch
    {
        public List<Professor> Search(Professor Searched, string path)
        {
            List<Professor> ResultProfessorList = new();
            XmlReader Reader = XmlReader.Create(path);
            string faculty = null;
            while (Reader.Read())
            {
                if (Reader.NodeType == XmlNodeType.Element)
                {
                    if (Reader.Name == "Faculty")
                    {
                        while(Reader.MoveToNextAttribute())
                        {
                            if (Reader.Name == "FACULTY")
                                faculty = Reader.Value;
                        }
                    }
                    if (Reader.Name == "Professor")
                    {
                        Professor professor = new();
                        professor.Faculty = faculty;
                        if (Reader.HasAttributes)
                        {
                            while (Reader.MoveToNextAttribute())
                            {
                                if (Reader.Name == "NAME")
                                    professor.Name = Reader.Value;
                                if (Reader.Name == "DEPARTMENT")
                                    professor.Department = Reader.Value;
                                if (Reader.Name == "SECTION")
                                    professor.Section = Reader.Value;
                                if (Reader.Name == "CATHEDRA")
                                    professor.Cathedra = Reader.Value;
                                if (Reader.Name == "PROFFECION")
                                    professor.Proffecion = Reader.Value;
                                if (Reader.Name == "OCCUPATION")
                                    professor.Occupation = Reader.Value;
                            }
                        }
                        if (professor.Match(Searched))
                            ResultProfessorList.Add(professor);
                    }
                }
            }
            return ResultProfessorList;
        }
    }
}
 /* public List<Professor> aSearch(Professor Searched, string path)
        {
            List<Professor> ResultProfessorList = new();                       
            XmlReader Reader = XmlReader.Create(path);
            string faculty = null;
            while (Reader.Read())
            {
                if (Reader.NodeType == XmlNodeType.Element)
                {
                    if (Reader.Name == "Faculty")
                    {
                        faculty = Reader.GetAttribute("FACULTY");
                    }
                    if (Reader.Name == "Professor")
                    {
                        Professor professor = new();
                        professor.Name = Reader.GetAttribute("NAME");
                        professor.Faculty = faculty;
                        professor.Department = Reader.GetAttribute("DEPARTMENT");
                        professor.Section = Reader.GetAttribute("SECTION");
                        professor.Cathedra = Reader.GetAttribute("CATHEDRA");
                        professor.Proffecion = Reader.GetAttribute("PROFFECION");
                        professor.Occupation = Reader.GetAttribute("OCCUPATION");
                        if (professor.Match(Searched))
                            ResultProfessorList.Add(professor);
                    }
                }
            }
            return ResultProfessorList;
        }*/