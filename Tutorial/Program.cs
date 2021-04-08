using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car("A1", "BMW", "550i", 55000, 2001),
                new Car("B2", "Honda", "Prelude", 2000, 1998),
                new Car("C3", "Toyota", "Camry", 10000, 2020)
            };
            //LINQ, basically SQL in C#?
            var bmws = from car in myCars
                       where car.Make == "BMW"
                       && car.Year == 2001
                       select car; //force to execute using .tolist
            Console.WriteLine("BMW:");
            foreach(var x in bmws)
            {
                Console.WriteLine("{0} {1} {2}", x.Make, x.Model, x.StickerPrice);
            }

            var sortedCars = from car in myCars
                             orderby car.StickerPrice
                             select car;
            foreach(var x in sortedCars)
            {
                Console.WriteLine("{0} {1} {2}", x.Make, x.Model, x.StickerPrice);
            }
            Console.ReadKey();

            //LINQ extension methods.
            var listBMW = myCars.Where(p => p.Make == "BMW" && p.StickerPrice < 100000);

        }
    }
}
