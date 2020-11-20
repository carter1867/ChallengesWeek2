using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2CallingChallenge
{
    class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine("hello " + name);
        }

        public void Farewell(string name)
        {
            Console.WriteLine("Farewell " + name);
        }

        public void WhatTimeIsIt(int currentTime)
        {
            

            if (currentTime > 6 && currentTime <= 11)
            {
                Console.WriteLine("Good morning");
            }

            else if (currentTime > 11 && currentTime <= 17)
            {
                Console.WriteLine("good afternoon");
            }

            else if (currentTime > 18 && currentTime <= 22)
            {
                Console.WriteLine("Good Evening");
            }

            else if (currentTime > 23 && currentTime <= 5)
            {
                Console.WriteLine("Good Night");
            }
        }
    }
}
