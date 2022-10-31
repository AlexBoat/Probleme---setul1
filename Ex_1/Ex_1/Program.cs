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
            //ax+b=0
            float a, b, x;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            x = -b / a;
            Console.WriteLine(x);
            Console.ReadLine();
        }
    }
}
