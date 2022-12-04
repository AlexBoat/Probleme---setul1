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
            int[] a = new int[4];
            for(int i=1; i<=3; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            bool sortat;
            do
            {
                sortat = true;
                for (int i = 1; i < 3; i++)
                    if (a[i] > a[i + 1])
                    {
                        a[i] = a[i] + a[i + 1];
                        a[i + 1] = a[i] - a[i + 1];
                        a[i] = a[i] - a[i + 1];
                        sortat = false;
                    }
            }
            while (!sortat);
            for (int i = 1; i <= 3; i++)
            {
                Console.Write(a[i] + " ");
            }
        }
    }
}
