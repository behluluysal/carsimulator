using System;
using System.Collections.Generic;
using System.Text;

namespace Araba_Odev3
{
     class Motor : Beyin
    {
        private string motortipi;
        public string Motortipi
        {
            set { motortipi = value; }
            get { return motortipi; }
        }

        public void Gazpedal(ConsoleKeyInfo x)
        {
            if (x.Key == ConsoleKey.UpArrow)
            {
                if (speed <= 220 && kontak == true)
                {
                    if (motortipi == "dizel")
                    {
                        speed += 8;
                        Console.SetCursorPosition(45, 2);
                        Console.Write(speed);
                    }
                    else if (motortipi == "benzinli")
                    {
                        speed += 10;
                        Console.SetCursorPosition(45, 2);
                        Console.Write(speed);
                    }
                }
                else
                    HataVurucu(0);
            }
            else if (x.Key == ConsoleKey.DownArrow)
            {
                    if (speed >= 10)
                    {
                        speed -= 10;
                        Console.SetCursorPosition(45, 2);
                        Console.Write(speed + " ");
                    }
                    else if (speed <= 10)
                    {
                        speed = 0;
                    Console.SetCursorPosition(45, 2);
                    Console.Write(speed + " ");
                    }
            }    
        }
    }
}
