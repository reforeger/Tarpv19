using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpv19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pls Enter your name: ");
            string name = Console.ReadLine();

            //Console.WriteLine("Hello " + name + "!");

            //string interpolation

            Console.WriteLine($"Hello, {name}!");
            Console.ReadLine();
        }
    }
}
