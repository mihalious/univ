using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Professor
    {
        public bool NullProfessor()
        {
            if (Name == null &&
                Faculty == null &&
                Department == null &&
                Section == null &&
                Cathedra == null &&
                Proffecion == null &&
                Occupation == null)
                return true;
            else
                return false;
        }

        public bool Match(Professor Searched)
        {
            if (!(Searched.NullProfessor()) &&
                (Searched.Name == null || Searched.Name == Name) &&
                (Searched.Faculty == null || Searched.Faculty == Faculty) &&
                (Searched.Department == null || Searched.Department == Department) &&
                (Searched.Section == null || Searched.Section == Section) &&
                (Searched.Cathedra == null || Searched.Cathedra == Cathedra) &&
                (Searched.Proffecion == null || Searched.Proffecion == Proffecion) &&
                (Searched.Occupation == null || Searched.Occupation == Occupation))
                return true;
            else
                return false;
        }
         
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public string Section
        {
            get { return section; }
            set { section = value; }
        }
        public string Cathedra
        {
            get { return cathedra; }
            set { cathedra = value; }
        }
        public string Proffecion
        {
            get { return proffecion; }
            set { proffecion = value; }
        }
        public string Occupation
        {
            get { return occupation; }
            set { occupation = value; }
        }        
        string name = null;
        string faculty = null;
        string department = null;
        string section = null;
        string cathedra = null;
        string proffecion = null;
        string occupation = null;        
    }
}
