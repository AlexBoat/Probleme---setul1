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
            //an bisect
            int an;
            bool ok = true;
            an = Convert.ToInt32(Console.ReadLine());
            if (an % 4 != 0)
                ok = false;
            if (an % 100 == 0)
                ok = false;
            if (an % 400 == 0)
                ok = true;
            if (ok == true)
                Console.WriteLine("{0} este an bisect", an);
            else
                Console.WriteLine("{0} nu este an bisect", an);
        }
    }
}
