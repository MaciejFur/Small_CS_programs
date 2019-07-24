using System;
using System.Text;

namespace Patterns
{
    class Program
    {
        public static void plus(int n)
        {
            string horizontal = new string('*', n);
            StringBuilder vertical = new StringBuilder().Insert(0, " ", n);

            vertical[vertical.Length / 2] = '*';

            for (int i = 0; i < 1; ++i)
            {
                for (int j = 0; j < n / 2; ++j)
                {
                    Console.WriteLine(vertical);
                }
                Console.WriteLine(horizontal);
                for (int j = 0; j < n / 2; ++j)
                {
                    Console.WriteLine(vertical);
                }
            }

        }
        public static void five(int n)
        {
            string top = new string('*', n);
            StringBuilder vertical = new StringBuilder().Insert(0, " ", n);

            vertical[vertical.Length - 1] = '*';

            Console.WriteLine(top);
            for (int i = 0; i < 1; i++)
            {
                for (int j = 0; j < n / 3 - 1; j++)
                {

                    Console.WriteLine('*');
                }
                Console.WriteLine(top);
                for (int j = 0; j < n / 3 - 1; j++)
                {

                    Console.WriteLine(vertical);
                }
                Console.WriteLine(top);


            }

        }
        public static void seven(int n)
        {
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n / 2; ++i)
            {
                StringBuilder vertical = new StringBuilder().Insert(0, " ", n);
                vertical[vertical.Length - 1 - i] = '*';
                Console.WriteLine(vertical);
                Console.WriteLine(vertical);
            }
        }

        public static void romb(int n)
        {
            
            
            for (int i = 0; i < n / 2; ++i)
            {
                StringBuilder up = new StringBuilder().Insert(0, " ", n);
                up[n / 2 + i] = '*';
                up[n / 2 - i] = '*';
                Console.WriteLine(up);
            }
            StringBuilder down = new StringBuilder().Insert(0, "*", n);
            Console.WriteLine(down);
            for (int i = 0; i < n / 2; ++i)
            {
                down[n - i - 1] = ' ';
                down[i] = ' ';
                Console.WriteLine(down);
            }
            


        }
        public static void literaA(int n)
        {
            StringBuilder line = new StringBuilder().Insert(0, " ", n);
            StringBuilder peak = new StringBuilder();
            for (int i = 0; i<n/3;i++)
            {
                peak = new StringBuilder().Insert(0, " ", n);
                peak[n / 2 - i] = '*';
                peak[n / 2 + i] = '*';
                line[n / 2 + i] = '*';
                line[n / 2 - i] = '*';
                Console.WriteLine(peak);

            }
            Console.WriteLine(line);
            for (int i = 0; i < n / 3; i++)
            {
                Console.WriteLine(peak);
            }
        }
        public static void drugieA(int n)
        {
            StringBuilder line = new StringBuilder().Insert(0, " ", n);
            StringBuilder peak = new StringBuilder();
            for (int i = 0; i < n / 2; i++)
            {
                peak = new StringBuilder().Insert(0, " ", n);
                peak[n / 2 - i] = '*';
                peak[n / 2 + i] = '*';
                line[n / 2 + i] = '*';
                line[n / 2 - i] = '*';
                Console.WriteLine(peak);
                if (i == n / 4)
                {
                    line[n / 2 + i+1] = '*';
                    line[n / 2 - i-1] = '*';
                    Console.WriteLine(line);
                    i++;
                }
            }
            
        }
        public static void Main()
        {
            drugieA(23);
            Console.ReadKey();
        }
    }
}