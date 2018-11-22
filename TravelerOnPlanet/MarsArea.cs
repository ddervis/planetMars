using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnPlanet
{
    public class MarsArea
    {
        public Tuple<int, int> Mars()
        {
            int x, y;
            Console.Write("Mars yuzey alaninin x kordinat uzunlugunu giriniz..:");
            x = Int32.Parse(Console.ReadLine());
            Console.Write("Mars yuzey alaninin y kordinat uzunlugunu giriniz..:");
            y = Int32.Parse(Console.ReadLine());

            int[,] mars = new int[x, y];

            var coordinates = new Tuple<int, int>(x, y);

            Console.WriteLine("Mars kordinatlari...:" + x + "," + y);
            Console.WriteLine(" ");

            return coordinates;
        }
    }
}