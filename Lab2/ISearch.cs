using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    public interface ISearch
    {
        public List<Professor> Search(Professor SearchProfessor, string path);
    }
}