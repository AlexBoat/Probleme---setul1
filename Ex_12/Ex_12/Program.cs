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
            int n, a, b, nr=0;
            n = Convert.ToInt32(Console.ReadLine());
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for(int i=a; i<=b; i++)
            {
                if(i%n==0)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
    }
}
