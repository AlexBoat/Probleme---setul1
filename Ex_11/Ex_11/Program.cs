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
            int n, ogl=0;
            n = Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                ogl = ogl * 10 + n % 10;
                n /= 10;
            }
            Console.WriteLine(ogl);
        }
    }
}
