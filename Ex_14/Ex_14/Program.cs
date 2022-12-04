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
            int n, aux, ogl = 0;
            n = Convert.ToInt32(Console.ReadLine());
            aux = n;
            while(aux!=0)
            {
                ogl = ogl * 10 + aux % 10;
                aux /=10;
            }
            if(n==ogl)
            {
                Console.WriteLine("{0} este palindrom", n);
            }
            else
                Console.WriteLine("{0} nu este palindrom", n);

        }
    }
}
