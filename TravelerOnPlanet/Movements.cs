using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnPlanet
{
    public class Movements
    {
        public void direction(string direct, string way, int x, int y, int planetX, int planetY)
        {

            string lastWay = way;
            int corX = x;
            int corY = y;
            int marsX = planetX;
            int marsY = planetY;
            string directWay = direct;
            char[] karakterler = directWay.ToCharArray();


            for (int z = 0; z < direct.Count(); z++)
            {
                if (karakterler[z] == 'm')
                {
                    if (lastWay == "n")
                    {
                        corY += 1;
                    }
                    else if (lastWay == "w")
                    {
                        corX += 1;
                    }
                    else if (lastWay == "s")
                    {
                        corY -= 1;
                    }
                    else if (lastWay == "e")
                    {
                        corX -= 1;
                    }
                }
                if (karakterler[z] == 'r')
                {
                    if (lastWay == "n")
                    {
                        lastWay = "w";
                    }
                    else if (lastWay == "w")
                    {
                        lastWay = "s";
                    }
                    else if (lastWay == "s")
                    {
                        lastWay = "e";
                    }
                    else if (lastWay == "e")
                    {
                        lastWay = "n";
                    }
                }
                if (karakterler[z] == 'l')
                {
                    if (lastWay == "n")
                    {
                        lastWay = "e";
                    }
                    else if (lastWay == "w")
                    {
                        lastWay = "n";
                    }
                    else if (lastWay == "s")
                    {
                        lastWay = "w";
                    }
                    else if (lastWay == "e")
                    {
                        lastWay = "s";
                    }
                }

            }
            if (corX > planetX)
            {
                corX = planetX;
            }
            else if (corX < 0)
            {
                corX = 0;
            }
            if (corY > planetY)
            {
                corY = planetY;
            }
            else if (corY < 0)
            {
                corY = 0;
            }
            Console.WriteLine("Makine Son Durumu");
            Console.WriteLine(corX + " " + corY + " " + lastWay);
            Console.WriteLine(" ");

        }
    }
}
