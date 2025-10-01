using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var contactList = new Hashtable();
            contactList.Add("Name", "Faizan");
            contactList.Add("Faizan",021345676);
            contactList.Add(1, "Faizan");
            Console.WriteLine(contactList["Name"]); //call with Key
            Console.WriteLine(contactList[1]);
            Console.WriteLine(contactList["Faizan"]);
        }
    }
}
