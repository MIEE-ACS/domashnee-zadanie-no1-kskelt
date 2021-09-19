using System;

namespace DZ1Eltanskaya
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("Введите первые координаты x1 и y1");
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x2 и y2");
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите координаты x3 и y3");
            int x3 = int.Parse(Console.ReadLine());
            int y3 = int.Parse(Console.ReadLine());
            double A = Math.Sqrt((Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)));
            double B = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double C = Math.Sqrt((Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)));

            if (A + B > C & A + C > B & C + B > A)
            {
                Console.WriteLine($"P={A + B + C}");
                double p = (A + B + C) / 2;
                Console.WriteLine($"S={Math.Sqrt(p * (p - A) * (p - B) * (p - C))}");
            }
            else
            {
                Console.WriteLine("Такого треугольника не существует");
            }
        }
    }
}

