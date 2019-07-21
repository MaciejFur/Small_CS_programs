﻿using System;
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
            StringBuilder builder = new StringBuilder().Insert(0, " ", n);
            Console.WriteLine(new string('*', n));
            for (int i = 0; i < n / 2; ++i)
            {
                Console.WriteLine('*');
            }
        }
        public static void Main()
        {
            romb(7);
            Console.ReadKey();
        }
    }
}