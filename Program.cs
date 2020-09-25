using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int Rz = 6371302;
            const double G = 6.67e-11, Mz = 5.97e24;

            double H, V;

            Console.Write("Введите высоту над поверхностью Земли: ");
            H = Convert.ToDouble(Console.Read());

            V = Math.Round(Math.Sqrt(G * Mz / (H + Rz)), 0);

            Console.WriteLine("Линейная скорость искусственного спутника планеты: " + V);
        }
    }
}
