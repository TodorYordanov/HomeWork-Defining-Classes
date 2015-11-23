using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Persons
{
    class PersonMain
    {
        static void Main(string[] args)
        {
            Person c = new Person();
            c.Name = Console.ReadLine();
            c.Age = int.Parse(Console.ReadLine());
            c.Email = Console.ReadLine();

            Console.WriteLine(c);

            //a.Name = ""; //This will throw exception:
            //b.Age = 102; //This will throw exception:
            //b.Email = "Q.AngelovAtabv.bg"; //This will throw exception:
        }
    }
}
