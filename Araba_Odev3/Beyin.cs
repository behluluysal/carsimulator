using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Araba_Odev3
{
    class Beyin
    {
        public int milliseconds = 1500;
        protected int hatakatsayisi;
        protected int speed = 0;
        public ConsoleKeyInfo m;
        protected int farlar = -1;
        protected bool kontak = false; //-1 kapalı 0-uzunfar 1-kısafar
        protected int sinyal = -1; // -1 sol  0-dörtlü  1-sağ  2-kapalı

        public void Farkontrol(ConsoleKeyInfo x)
        {
            if(x.Key == ConsoleKey.F && farlar==-1)
            {
                Console.SetCursorPosition(8, 4);
                Console.Write("Kısa Farlar");
                farlar ++;
            }
            else if(x.Key == ConsoleKey.F && farlar == 0)
            {
                Console.SetCursorPosition(8, 4);
                Console.Write("Uzun Farlar");
                farlar++;
            }
            else if (x.Key == ConsoleKey.F && farlar == 1)
            {
                Console.SetCursorPosition(8, 4);
                Console.Write("Kapalı      ");
                farlar = -1;
            }
        }
        public void Sinyalkontrol(ConsoleKeyInfo x)
        {
            if (x.Key == ConsoleKey.S && sinyal == -1)
            {
                Console.SetCursorPosition(44, 4);
                Console.Write("Sol Sinyal");
                sinyal++;
            }
            else if (x.Key == ConsoleKey.S && sinyal == 0)
            {
                Console.SetCursorPosition(44, 4);
                Console.Write("Dörtlü    ");
                sinyal++;
            }
            else if (x.Key == ConsoleKey.S && sinyal == 1)
            {
                Console.SetCursorPosition(44, 4);
                Console.Write("Sağ Sinyal");
                sinyal ++;
            }
            else if (x.Key == ConsoleKey.S && sinyal == 2)
            {
                Console.SetCursorPosition(44, 4);
                Console.Write("Kapalı    ");
                sinyal = -1;
            }
        }
        public void kontakkontrol(ConsoleKeyInfo x)
        {
            if(x.Key == ConsoleKey.K)
            {
                if (kontak == false)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("Açık  ");
                    kontak = true;
                }
                else if (kontak == true && speed == 0)
                {
                    Console.SetCursorPosition(11, 2);
                    Console.Write("Kapalı");
                    kontak = false;
                }
                else
                    HataVurucu(1);

            }
        }
        public void HataVurucu(int x)
        {
            if(x == 0)
            {
                Console.SetCursorPosition(0, 9);
                Console.Write("Kontak açılmadan araba hızlandırılamaz!");
                Thread.Sleep(milliseconds);
                Console.SetCursorPosition(0, 9);
                Console.Write("                                        ");
            }
            else if (x == 1)
            {
                Console.SetCursorPosition(0, 9);
                Console.Write("Araba hareket halindeyken kontak kapatılamaz!");
                Thread.Sleep(milliseconds);
                Console.SetCursorPosition(0, 9);
                Console.Write("                                              ");
            }
        }
    }
}
