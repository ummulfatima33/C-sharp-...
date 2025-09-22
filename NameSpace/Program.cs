using Namespace2;
using FileLevel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSpace
{
    internal class Program
    {
       static void Main(string[] args)
        {
                 //NameSpace 1 Objects
            Students students = new Students();
            students.name("Ali Raza");

            Students students1 = new Students();
            students1.name("Yaqoob");

            Teacher teacher = new Teacher();
            teacher.course("ADSE");

            //NameSpace 2 Objects

            Namespace2.Teacher teacher1 = new Namespace2.Teacher();
            teacher1.tname("Sir Rizwan");

            Subject subject = new Subject();
            subject.module(3);


            //FileLevel Objects

            ClassA obj = new ClassA();
          

        }
    }
}
            
