using System;

namespace Araba_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu sa;
            sa = new Menu();
            Console.Clear();
            sa.menu();
            Console.ReadKey();
        }
    }
}
