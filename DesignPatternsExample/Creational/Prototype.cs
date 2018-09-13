using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExample.Creational
{
    public abstract class PhonePrototype
    {
        public string Model { get; set; }
        public int Price { get; set; }

        public static int GeneratePrice(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public abstract PhonePrototype Clone();
    }

    public class CellularPhonePrototype : PhonePrototype
    {
        public CellularPhonePrototype(string str)
        {
            Model = str;
            Price = GeneratePrice(10000, 100000);
        }

        public override PhonePrototype Clone()
        {
            return (CellularPhonePrototype) this.MemberwiseClone();
        }
    }

    public class StationaryPhonePrototype : PhonePrototype
    {
        public StationaryPhonePrototype(string str)
        {
            Model = str;
            Price = GeneratePrice(0, 10000);
        }

        public override PhonePrototype Clone()
        {
            return (StationaryPhonePrototype)this.MemberwiseClone();
        }
    }
}
