using System;
namespace Ders_01
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, c, result;

            Console.Write("a : ");
            a = float.Parse(Console.ReadLine());

            Console.Write("b : ");
            b = float.Parse(Console.ReadLine());

            Console.Write("c : ");
            c = float.Parse(Console.ReadLine());

            result = Max(a, b, c);
            Console.Write("En buyuk sayi :");
            Console.WriteLine(result);
        }
        public static float Max(float a, float b, float c)
        {
            return a > b ? (a > c ? a : c) : (b > c ? b : c);
        }
    }
}
