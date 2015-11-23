using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02LaptopShop
{
    class LaptopShop
    {
        static void Main()
        {
            Laptop temp1 = new Laptop("Lenovo Yoga 2 Pro", "Lenovo", "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                8, "Intel HD Graphics 4400", "128GB SSD", "13.3\" (33.78 cm) – 3200 x 1800(QHD +), IPS sensor display",
                new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5), 699.00m);
            Laptop temp2 = new Laptop("HP", 899.99m);
            Console.WriteLine(temp1);
            Console.WriteLine(temp2);
        }
    }
}
