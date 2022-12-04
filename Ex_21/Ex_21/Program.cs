using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nr_citit=0, nr_generat=0;
            Random r = new Random();
            nr_generat = Convert.ToInt32(r.Next(2, 1024));
            Console.WriteLine("Am generat un numar intre 1 si 1024. Multa bafta sa-l ghicesti!");
            while (nr_citit != nr_generat)
            {
                nr_citit = int.Parse(Console.ReadLine());
                if(nr_citit > 1023 || nr_citit < 2)
                {
                    Console.WriteLine("{0} este in afara intervalului 1-1024...", nr_citit);
                }
                else
                {
                    if(nr_citit > nr_generat)
                    {
                        Console.WriteLine("{0} este mai mare decat numarul ce trebuie ghicit...", nr_citit);
                    }
                    if(nr_citit < nr_generat)
                    {
                        Console.WriteLine("{0} este mai mic decat numarul ce trebuie ghicit...", nr_citit);
                    }
                }
            }
            Console.WriteLine("Felicitari, ai ghicit numarul generat aleatoriu!");
            Console.Read();
        }
    }
}
