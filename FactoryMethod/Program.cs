using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Developer dev = new PanelDeveloper("Kirpich stroy");
            House house2 = dev.Create();

            dev = new WoodDeveloper("Private developer");
            House house = dev.Create();

            Console.ReadLine();
        }
    }
}
