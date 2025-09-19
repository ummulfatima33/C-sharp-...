using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationANDproperties
{
    internal class Student
    {
        private string name;
        private int age;
      
        public void setDetails(string stdname, int stdage)
        {
            this.name = stdname;
            if (stdage > 0)
            {
               
                this.age = stdage;
            } else
            {
                Console.WriteLine("Please enter valid input");
            }
            getDetail();
        }

          // private modify use kia h es lye method ko setDetail m call krwya h upr
        private void getDetail()
        {
            Console.WriteLine("Student name {0} " +
                "& age is {1}", this.name, this.age);
        }

    }

}
