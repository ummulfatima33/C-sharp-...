using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulationANDproperties
{
    internal class Properties
    {
        private string _name;  // field
        private int _age;  // field
        private string _mobile = "021345676547";  // field
        private int _bankBalance;  // field


        public string name    {    // Property   
            get { return _name; }    // Read & Write 
            set { _name = value; } 
       }

        public int age  {    // Property
            get { return _age; }
            set
            {
                if (value > 0)
                    _age = value;
                else { Console.WriteLine("Please enter valid input"); }
            }
        }
             public string mobile {    // Property
            get { return _mobile; }   //read only
        }

        public int bankBalance
        {    // Property
            set {_bankBalance = value; }   // write only
        }

    }
}
