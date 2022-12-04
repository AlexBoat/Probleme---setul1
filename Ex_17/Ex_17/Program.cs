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
            int a, b, n, m;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            n = a;
            m = b;
            while (n != m)
                if (n > m)
                    n -= m;
                else
                    m -= n;
            Console.WriteLine("Cmmdc: {0}",n);
            n = a;
            m = b;
            while (n != m)
            {
                if (n < m)
                    n = n + a;
                else
                    m = m + b;
            }
            Console.WriteLine("Cmmmc: {0}", n);

        }
    }
}
