using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_method;

namespace print_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter greet = new Greeter(); //made new instance of greeter class

            greet.SayHello("Carter"); //called say hello method using dot notation.
            Console.ReadLine();

        }
    }
}
