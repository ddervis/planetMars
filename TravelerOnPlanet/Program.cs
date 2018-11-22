using TravelerOnPlanet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerOnPlanet
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //Burada MarsAre sınıfından mars ölçüleri belirleniyor
            MarsArea newPlanet = new MarsArea();
            var planetMars = newPlanet.Mars();
           
            //Robot sınıfından robot1 oluşturuluyor
            Robot robot1 = new Robot();
            var properties1 = robot1.robotBuilder();


            //Robot sınıfından robot2 oluşturuluyor
            Robot robot2 = new Robot();
            var properties2 = robot2.robotBuilder();

            Console.Write(properties1.Item4+" adlı robot icin kod gonderin...:");
            string robot1Code = Console.ReadLine();
            Movements katar = new Movements();

            //Bütün hareket alanımızı belirleyecek olan movements sınıfına kullanıcıdan aldığımı verileri sonuca ulaşmak üzere gönderiyoruz.
            katar.direction(robot1Code, properties1.Item3,properties1.Item1, properties1.Item2, planetMars.Item1, planetMars.Item2);
            Console.Write(properties2.Item4+" adlı robot icin kod gonderin...:");
            string robot2Code = Console.ReadLine();
            katar.direction(robot2Code, properties2.Item3,properties2.Item1,properties2.Item2, planetMars.Item1, planetMars.Item2);



            Console.ReadKey();

        }
    }
}
