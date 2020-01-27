using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsCSharpe
{
    class Program
    {
        static void Main(string[] args)
        {
            menuItems();
        }

        private static void helloWorld()
        {
            Console.WriteLine("\nHello World");
            Console.ReadKey();
        }

        private static void menuItems()
        {
            Console.WriteLine("Enter the number of the function you wish to call:");
            Console.WriteLine("1. Hello World");
            char menuitem = Console.ReadKey().KeyChar;


            switch(menuitem)
            {
                case '1':
                    helloWorld();
                    break;
                default:
                    Console.WriteLine("Invalid item");
                    break;
            }
        }
    }
}
