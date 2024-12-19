using Akib_1281742.Factories;
using Akib_1281742.Tests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akib_1281742
{
    internal class Program
    {
        static void Main()
        {
            DITest1 di1 = new DITest1(new RepositoryFactoryImpl());
            di1.Run();
            Console.WriteLine("======================");
            DITest2 di2 = new DITest2();
            di2.Run(new RepositoryFactoryImpl());
            Console.ReadLine();
        }
    }
}
