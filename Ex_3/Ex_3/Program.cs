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
            //n se divide cu k
            int n, k;
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            if(n%k==0)
            {
                Console.WriteLine("{0} se divide cu {1}", n, k);
            }
            else
                Console.WriteLine("{0} nu se divide cu {1}", n, k);
        }
    }
}
