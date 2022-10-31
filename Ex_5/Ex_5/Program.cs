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
            // a k-a cifra a unui numar
            int nr, k;
            nr = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<k; i++)
            {
                nr /= 10;
            }
            Console.WriteLine("A {0}-a cifra este {1}",k, nr % 10);
        }
    }
}
