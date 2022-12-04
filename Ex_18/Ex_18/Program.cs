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
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int d = 2, p;      
            while (n > 1)
            {
                p = 0;
                while (n % d == 0)
                {
                    ++p;
                    n /= d;
                }
                if (p!=0)
                    Console.WriteLine("{0} {1}", d, p);
                ++d;
                if (n > 1 && d * d > n)
                {
                    d = n;
                }
            }
        }
    }
}
