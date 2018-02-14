using System;

namespace DotNetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started Console app");
            for (int i = 1; ; i++)
            {
                Console.WriteLine("Loop # {0}", i);
                System.Threading.Thread.Sleep(300000);
            }
        }
    }
}
