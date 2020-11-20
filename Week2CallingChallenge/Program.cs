using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CallingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeter program = new Greeter();

            program.SayHello("Carter");

            program.Farewell("Kaminski");

            program.WhatTimeIsIt(13);
            
            Console.ReadKey();
        }


    }
}
