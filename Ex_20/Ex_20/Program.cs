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
        public static bool isprim(int n)
        {
            for (int d = 2; d * d <= n; d++)
                if (n % d == 0)
                    return false;
            return true;
        }
        public static void Main(string[] args)
        {
            bool ok = false;
            float m, n;
            m = float.Parse(Console.ReadLine());
            n = float.Parse(Console.ReadLine());
            //periodica mixta
            
            for(int i=3; i<=n; i++)
            {
                if(isprim(i))
                {
                    if((n%2==0 || n%5==0) && n%i==0)
                    {
                        //Console.WriteLine(m / n);
                        Console.Write("Ioi nu, fractie periodica mixta...");
                        ok = true;
                        break;
                    }

                }

            }
            //periodica simpla
            if(ok==false)
            {
                if(n % 2 != 0 && n % 5 != 0)
                {
                    Console.Write(Convert.ToInt32(m / n));
                    Console.Write(".(");
                    if(n<m)
                        Console.Write(n%m + ")");
                    else
                        Console.Write(m%n + ")");

                }
                //neperiodica
                else
                    Console.WriteLine(m / n);

            }
            
        }
    }
}
