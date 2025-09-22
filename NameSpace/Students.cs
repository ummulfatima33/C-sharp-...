using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace
{
    internal class Students
    {
        public void name(string sname)
        {
            Console.WriteLine("Name is " + sname);
        }
    }

    class Teacher
    {
        public void course(string course)
        {
            Console.WriteLine("Enroll  " + course);
        }
    }
}

namespace Namespace2
{
    class Student
    {

    }
 class Teacher
    {
        public void tname(string fname)
        {
            Console.WriteLine("Teacher Name Is  " + fname);
        }
    }
    class Subject
    {
        public void module(int module)
        {
            Console.WriteLine("Module Version  " + module);
        }
    }
}
