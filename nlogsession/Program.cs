using System;
using NLog;

namespace nlogsession
{
    class Program
    {
        public static Logger logger = LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            Console.WriteLine("the value of a is :");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("the value of b is :");
            int b = int.Parse(Console.ReadLine());
            addition add = new addition();
            Console.WriteLine(add.sum(a, b));
        }
    }
}
