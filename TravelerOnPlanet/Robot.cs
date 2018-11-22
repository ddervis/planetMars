using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnPlanet
{
    public class Robot
    {
        public Tuple<int, int, string, string> robotBuilder()
        {
            int x, y;
            string name, way;

            Console.Write("Robot adi giriniz..:");
            name = Console.ReadLine();
            Console.Write(name + " robotunun yonunu giriniz(N,W,S,E)..:");
            way = Console.ReadLine();
            if (way != "n" && way != "w" && way != "s" && way != "e")
            {
                Console.WriteLine("Yanlis bir yon girdiniz tekrar deneyin");
                way = Console.ReadLine();
                Console.WriteLine(" ");
            }

            Console.Write(name + " robotunun konumunun x noktasini giriniz..:");
            x = Int32.Parse(Console.ReadLine());
            Console.Write(name + " robotunun konumunun y noktasini giriniz..:");
            y = Int32.Parse(Console.ReadLine());

            Console.WriteLine(name + " robotunun konumu (" + x + "," + y + ") olarak belirlendi.");
            Console.WriteLine(" ");

            var properties = new Tuple<int, int, string, string>(x, y, way, name);

            return properties;

        }


    }
}
