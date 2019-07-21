using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int KtoraKolumna(int[,] a)
        {
            List<double> srednie = new List<double>(new double[a.GetLength(1)]);
            

            for (int i = 0; i < a.GetLength(0); ++i)
            {
                for (int j = 0; j < a.GetLength(1); ++j)
                {
                    srednie[j] += a[i, j];
                }
            }

            for (int i = 0; i < srednie.Count(); ++i)
            {
                srednie[i] /= a.GetLength(0);
            }

            return srednie.IndexOf(srednie.Min());
        }

        public static void Main()
        {
            int[,] a = new int[5, 4] { { 1, 1, 1, 0 }, { -2, -3, 2, 1 }, { 2, -5, 0, -1 }, { -3, 4, 6, 2 }, { -6, 6, 3, 4 } };
            Console.WriteLine("numer kolumny z najmniejszą sumą = " + KtoraKolumna(a));
        }
    }
}