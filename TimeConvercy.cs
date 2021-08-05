using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace TransferConvercy
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine("Enter your Time");
            var s = Console.ReadLine();
            Console.WriteLine(ConvertTime(s));
            Console.ReadKey;
        }

        static string ConvertTime (string s)
        {
            return DateTime.Parse(s).ToString("HH:mm:ss");
        }
    }
}
