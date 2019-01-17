using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main( string[] args )
        {
            string name;
            
            Console.WriteLine("Enter your name");
            name = Console.ReadLine();
            Console.WriteLine("Hello "); //console.writeline is a function call
            Console.WriteLine(name);
            
        }
    }
}
