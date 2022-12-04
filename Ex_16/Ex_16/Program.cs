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
            int a, b, c, d, e;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());
            e = Convert.ToInt32(Console.ReadLine());
            if(a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }
            if(c>d)
            {
                c = c + d;
                d = c - d;
                c = c - d;
            }
            if(b>d)
            {
                b = b + d;
                d = b - d;
                b = b - d;
            }
            if(c>e)
            {
                c = c + e;
                e = c - e;
                c = c - e;
            }
            if(b>e)
            {
                b = b + e;
                e = b - e;
                b = b - e;
            }
            if (a > c)
            {
                a = a + c;
                c = a - c;
                a = a - c;
            }
            if(b>c)
            {
                b = b + c;
                c = b - c;
                b = b - c;
            }
            if(d>e)
            {
                d = d + e;
                e = d - e;
                d = d - e;
            }
            if (c > d)
            {
                c = c + d;
                d = c - d;
                c = c - d;
            }
            Console.WriteLine(a + " " + b + " " + c + " " + d + " " + e);
        }
    }
}
