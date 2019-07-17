using System;

namespace ConsoleApp3
{
    class Program
    {
        public static double ObjetoscOstroslupa(double podstawa, double krawedz)
        {
            if (podstawa <= 0 || krawedz <= 0)
            {
                throw new Exception("Musiz podac liczbe wieksza od zera.");
            }
            if (krawedz <= (2 / 3d) * ((podstawa * Math.Sqrt(3)) / 2))
            {
                throw new Exception("Podana krawedz jest za krotka.");
            }



            double poleP = (Math.Pow(podstawa, 2) * Math.Sqrt(3)) / 4;
            double wysokoscP = (2 / 3d) * ((podstawa * Math.Sqrt(3)) / 2);
            double wysokosc = Math.Pow(krawedz, 2) - Math.Pow(wysokoscP, 2);
            wysokosc = Math.Sqrt(wysokosc);

            double objetosc = (1 / 3d) * poleP * wysokosc;
            
            return objetosc;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(ObjetoscOstroslupa(10, 1));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("czesc");
            }
            Console.ReadKey();
        }
    }
}
