using System;
using System.Collections.Generic;
using System.Text;

namespace Araba_Odev3
{
    class Direksiyon : Motor
    {
        protected int yön = 0;
        private int yön2;

        public void yon(ConsoleKeyInfo x)
        {
            if (x.Key == ConsoleKey.RightArrow && yön <45)
            {
                yön += 5;
            }
            else if (x.Key == ConsoleKey.LeftArrow && yön>-45)
            {
                yön -= 5;
            }
            yön2 = yön * -1;
            if (yön<=45 && yön>0)
            {
                Console.SetCursorPosition(17, 6);
                Console.Write("Sağa doğru " + yön + " derece    ");
            }
            else if(yön>=-45 && yön < 0)
            {
                Console.SetCursorPosition(17, 6);
                Console.Write("Sola doğru " + yön2 + " derece    ");
            }
            else
            {
                Console.SetCursorPosition(17, 6);
                Console.Write("Tekerlerlek düz konumda.           ");
            }

            
        }
    }
}
