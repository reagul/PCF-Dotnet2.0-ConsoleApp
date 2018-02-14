using System;
using System.Threading;

namespace DotNetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started Console app");
            for (int i = 1; ; i++)
            {
                Console.WriteLine($"Loop # {i}");
                Thread.Sleep(TimeSpan.FromMinutes(3));
            }
        }
    }
}
