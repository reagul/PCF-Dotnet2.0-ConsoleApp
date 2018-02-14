using System;

namespace DotNetCore2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Started Console app");
            int i; 
            i = 1; 	
            while (true)
            {
                Console.WriteLine("Loop # {0}", i);
                System.Threading.Thread.Sleep(300000);
                i++;
            }
        }
    }
}
