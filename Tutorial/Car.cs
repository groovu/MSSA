using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Car
    {
        public string VIN { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int StickerPrice { get; set; }
        public int Year { get; set; }

        public Car(string vin, string make, string model, int stickerprice, int year)
        {
            VIN = vin; Make = make; Model = model; StickerPrice = stickerprice; Year = year;
        }
    }
}
