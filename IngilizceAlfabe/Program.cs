using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngilizceAlfabe
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
            for (char c = 'A'; c <= 'z'; c++)
            {
                if (c <='Z' || c >= 'a')
                {
                    Console.Write(c + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
