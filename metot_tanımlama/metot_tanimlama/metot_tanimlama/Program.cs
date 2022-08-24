using System;

namespace metot_tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            Degistir(ref x, ref y);
            Console.WriteLine("X = " + x.ToString());
            Console.WriteLine("Y = " + y.ToString());
        }
        static void Degistir(ref int x , ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
