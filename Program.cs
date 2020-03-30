using System;

namespace The_Coffe_Mechine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            CoffePowder coffe = new CoffePowder(100);
            WaterGalon water = new WaterGalon(1000);
            Milk milk = new Milk(100);
            CoffeMechine yummyCoffe = new CoffeMechine(coffe,water,milk);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            String result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeEsspresso();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
            result = yummyCoffe.makeCappucino();
            Console.WriteLine("result" + result);

            Console.WriteLine("check" + yummyCoffe.checkAvailability());
        }
    }
}
