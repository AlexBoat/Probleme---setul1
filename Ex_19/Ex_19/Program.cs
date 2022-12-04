using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Dynamic;

namespace Standard
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, c1=0, c2=0, aux;
            bool ok = false;
            n = Convert.ToInt32(Console.ReadLine());
            aux = n;
            c1 = aux % 10;
            c2 = c1;
            aux /= 10;
            while(aux!=0)
            {
                if(aux%10!=c1 && ok==false)
                {
                    c2 = aux % 10;
                    ok = true;
                }
                if(aux%10!=c1 && aux%10 != c2 && ok == true)
                {
                    ok = false;
                    break;
                }
                aux /= 10;
            }
            if(ok==false)
                Console.WriteLine("{0} nu este format doar din 2 cifre ce se pot repeta", n);
            else
                Console.WriteLine("{0} este format doar din 2 cifre ce se pot repeta", n);
        }
    }
}
