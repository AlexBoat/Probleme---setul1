using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Standard
{
    class Program
    {
        public static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0 && c > 0 && (a + b > c || a + c > b || b + c > a))
            {
                Console.WriteLine("{0} {1} {2} pot forma un triunghi", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2} nu pot forma un triunghi", a, b, c);
            }
        }
    }
}
