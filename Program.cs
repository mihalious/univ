using System.Collections.Generic;
using System;
namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            string select = "0";            
            do
            {
                Console.WriteLine("что бы создать группу введите 1, что бы завершить введите 0");                
                select = InputOutput.TrueSelect(Console.ReadLine());                                              
                Group group = InputOutput.GroupInput(select);
                InputOutput.StudentsInput(group);               
            } while (select != "0");
           
            if(Group.GetCnt != 0)
            {
                Console.WriteLine("вывести информацию о группах введите 1, что бы завершить введите 0");
                InputOutput.GroupOutput(InputOutput.TrueSelect(Console.ReadLine()));
            }            
        }
    }

    abstract class Student
    {
        protected string name, state;

        public string GetName
        {
            get { return name; }
        }

        public string GetState
        {
            get { return state; }
        }

        public Student(string _name)
        {
            name = _name;
            state = null;
        }
        public void Relax()
        {
            state += "Relax";
        }

        public void Read()
        {
            state += "Read";

        }

        public void Write()
        {
            state += "Write";
        }
        abstract public void Study();
    }

    class GoodStudent : Student
    {

        public GoodStudent(string _name) : base(_name)
        {
            state += "good";
        }

        override public void Study()
        {
            for (int i = 0; i < 2; ++i)
            {
                Read();
                Write();
            }
            Relax();
        }
    }

    class BadStudent : Student
    {

        public BadStudent(string _name) : base(_name)
        {
            state += "bad";
        }

        override public void Study()
        {
            for (int i = 0; i < 3; ++i)
            {
                Relax();
            }
            Read();
        }
    }

    class Group
    {
        string nameOfGroup;
        List<Student> listOfStudents = new();
        static int cnt = 0;
        public static int GetCnt
        {
            get { return cnt; }
        }       

        public Group(string _name)
        {
            nameOfGroup = _name;
            ++cnt;
        }

        public string GetNameOFGroup
        {
            get { return nameOfGroup; }
        }

        public void AddStudent(Student st)
        {
            listOfStudents.Add(st);
        }

        public void GetInfo()
        {
            string info = nameOfGroup;
            for (int i = 0; i < listOfStudents.Count; ++i)
            {
                info += (", " + listOfStudents[i].GetName);
            }
            Console.WriteLine(info);
        }

        public void GetFullInfo()
        {
            string fullInfo = nameOfGroup;
            for (int i = 0; i < listOfStudents.Count; ++i)
            {
                fullInfo += (", " + listOfStudents[i].GetName + ": " + listOfStudents[i].GetState);
            }
            Console.WriteLine(fullInfo);
        }
    }

    static class InputOutput
    {
        public static string TrueSelect(string _select) //гарантирует правильность ввода
        {
            while (!((_select == "1") || (_select == "0")))
            {
                Console.WriteLine("введите 1 или 0");
                _select = Console.ReadLine();
            }
            return _select;
        }

        static List<Group> listOfGroups = new(); //список всех созданных групп
        public static void AddGroup(Group _group)
        {
            listOfGroups.Add(_group);
        }

        public static Group GroupInput(string _select) //создание группы
        {
            Group group = null;
            if (_select == "1")
            {
                Console.WriteLine("введите название группы");
                string nameOfGroup = Console.ReadLine();
                group = new(nameOfGroup);
                InputOutput.AddGroup(group);
                return group;
            }
            return group;
        }

        public static void StudentsInput(Group _group) //добавление студентов в группу
        {
            if (_group != null)
            {
                int i = 0;
                string name;
                Console.WriteLine("добавте студентов в группу " + _group.GetNameOFGroup);
                while (true)
                {
                    Console.WriteLine("введите имя студента или 0 что бы завершить");
                    name = Console.ReadLine();
                    if (name == "0")
                    {
                        string k;
                        k = i.ToString();
                        Console.WriteLine(k + " студентов добавлено в группу " + _group.GetNameOFGroup);
                        return;
                    }

                    Console.WriteLine("если студент " + name + " учится хорошо нажмите 1, плохо- нажмите 0");

                    switch (InputOutput.TrueSelect(Console.ReadLine()))
                    {
                        case "1":
                            GoodStudent goodStudent = new(name);

                            _group.AddStudent(goodStudent);
                            ++i;
                            break;

                        case "0":
                            BadStudent badStudent = new BadStudent(name);
                            _group.AddStudent(badStudent);
                            ++i;
                            break;

                            //default: break; // т.к. введено точно или 1 или 0 default не нужен
                    }
                } 
            }
            return;
        }        

        public static void GroupOutput(string _select)
        {
            if ((_select == "1"))
            {
                for (int i = 0; i < listOfGroups.Count; ++i)
                {
                    Console.WriteLine("вывести всю информацию о группе " + listOfGroups[i].GetNameOFGroup + " введите 1," +
                        " вывести только имена студентов- введите 0");
                    switch (InputOutput.TrueSelect(Console.ReadLine()))
                    {
                        case "1":
                            listOfGroups[i].GetFullInfo();
                            break;

                        case "0":
                            listOfGroups[i].GetInfo();
                            break;

                            //default: break; // т.к. введено точно или 1 или 0 default не нужен
                    }

                }
            }
        }

    }


}
