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
        public static bool bisect(int an)
        {
            if (an % 400 == 0)
            {
                return true;
            }
            if (an % 100 == 0)
            {
                return false;
            }
            if (an % 4 == 0)
            {
                return true;
            }
            return false;
            
        }
        public static void Main(string[] args)
        {
            int y1, y2;
            int nr=0;
            y1 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            for(int i=y1; i<=y2; i++)
            {
                if(bisect(i)==true)
                {
                    nr++;
                }
            }
            Console.WriteLine(nr);
        }
    }
}
