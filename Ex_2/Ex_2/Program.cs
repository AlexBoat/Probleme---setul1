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
            //ax^2+bx+c=0
            float a, b, c, delta;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            delta = (b * b) - (4 * a * c);
            if(delta>0)
            {
                Console.Write("X1=");
                Console.Write((-b-Math.Sqrt(delta))/(2*a));
                Console.WriteLine();
                Console.Write("X2=");
                Console.Write((-b + Math.Sqrt(delta)) / (2 * a));
                Console.WriteLine();
            }
            else
            {
                if(delta==0)
                {
                    Console.Write("X=");
                    Console.Write(-b / (2 * a));
                }
                else
                {
                    Console.Write("X1=");
                    Console.Write(-b / (2 * a));
                    Console.Write("-i");
                    Console.Write((Math.Sqrt(-delta))/(2*a));
                    Console.WriteLine();
                    Console.Write("X1=");
                    Console.Write(-b / (2 * a));
                    Console.Write("+i");
                    Console.Write((Math.Sqrt(-delta)) / (2 * a));
                }

            }
        }
    }
}
