using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CSharpChallengesWeek2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SayHello(string name)
        {
            Console.WriteLine("Hello " + name);

        }

        
    }
}
