using System;
using System.Collections.Generic;
using System.Text;

namespace Araba_Odev3
{
    class Menu : Direksiyon
    {
        
        public void menu()
        {
            int a=1;
            int b = 1;
            do
            {
                if(b ==1 )
                {
                    Console.WriteLine("Dizel mi benzinli mi?");
                    Motortipi = Console.ReadLine();
                    Console.ReadKey();
                    Console.Clear();
                    Console.Write(
"--------------------------------------------------------\n" +
"--------------------------------------------------------\n" +
"-- Kontak:              |||          Hız:             --\n" +
"--------------------------------------------------------\n" +
"-- Far:                 |||        Sinyal:            --\n" +
"--------------------------------------------------------\n" +
"--Tekerler Yönü:                                      --\n" +
"--------------------------------------------------------\n" +
"--------------------------------------------------------");
                    Console.SetCursorPosition(8, 4);
                    Console.Write("Kapalı  ");
                    Console.SetCursorPosition(44, 4);
                    Console.Write("Kapalı  ");
                    Console.SetCursorPosition(11, 2);
                    Console.Write("Kapalı  ");
                    b = 0;
                }


                m = Console.ReadKey(true);
                menukontrol(m);

            } while (a != 0);
        }
        
        public void menukontrol(ConsoleKeyInfo x)
        {
            if (x.Key == ConsoleKey.F)
                Farkontrol(x);
            else if (x.Key == ConsoleKey.S)
                Sinyalkontrol(x);
            else if (x.Key == ConsoleKey.UpArrow || x.Key == ConsoleKey.DownArrow)
                Gazpedal(x);
            else if (x.Key == ConsoleKey.K)
                kontakkontrol(x);
            else if (x.Key == ConsoleKey.RightArrow || x.Key == ConsoleKey.LeftArrow)
                yon(x);
                

            

            
        }
    }
}
