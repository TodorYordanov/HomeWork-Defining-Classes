using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03PCCatalog
{
    class PCCatalog
    {
        static void Main()
        {
            List<Computer> computers = AddComputers();

            foreach (var computer in computers)
            {
                Console.WriteLine(computer.ToString());
            }

        }

        static List<Computer> AddComputers()
        {
            List<Computer> computers = new List<Computer>();
            string ch = null;

            do
            {
                Console.Write("Enter the computer name: ");
                string name = Console.ReadLine();

                List<Component> components = AddComponents();

                Computer computer = new Computer(name, components);
                computers.Add(computer);

                Console.Write("\nDo you want to add another computer (y/n)?");
                ch = Console.ReadLine();
                Console.WriteLine();
            }
            while (ch != "n" && ch != "N");


            return computers;
        }

        static List<Component> AddComponents()
        {
            List<Component> components = new List<Component>();
            string ch = null;

            do
            {
                Console.Write("Enter the component name: ");
                string name = Console.ReadLine();
                Console.Write("Enter the component description (not mandatory): ");
                string desc = Console.ReadLine();
                Console.Write("Enter the component price: ");
                double price = Double.Parse(Console.ReadLine());

                Component component = new Component(name, price, desc);
                components.Add(component);

                Console.Write("\nDo you want to add another component (y/n)? ");
                ch = Console.ReadLine();
            }
            while (ch != "n" && ch != "N");

            return components;
        }
    }
}
