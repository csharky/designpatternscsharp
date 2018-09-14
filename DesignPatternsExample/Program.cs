using System;

namespace DesignPatternsExample
{
    class Program
    {
        private static void Depart(string name, System.Action action, bool category = false)
        {
            var firstLine = "------------- " + name + " -------------";

            if (category)
            {
                firstLine = "------------- " + name + " -------------\n";
            }

            Console.WriteLine(firstLine);

            action();

            for (int i = 0; i < firstLine.Length; i++)
                Console.Write("-");

            Console.WriteLine("\n");
        }

        static void Main(string[] args)
        {
            Depart("Creational Patterns", () => {
                Depart("Singleton", () =>
                {
                    var content = Creational.Singleton.Instance.GetContent();
                    Console.WriteLine(content);
                });

                Depart("Prototype", () =>
                {
                    var firstPrototype = new Creational.CellularPhonePrototype("iPhone");
                    var firstPrototypeClone = firstPrototype.Clone();
                    var secondPrototype = new Creational.StationaryPhonePrototype("Siemens");
                    var secondPrototypeClone = secondPrototype.Clone();

                    Console.WriteLine("First: \t\t" + firstPrototype.Model + "\t\t" + firstPrototype.Price);
                    Console.WriteLine("Clone: \t\t" + firstPrototypeClone.Model + "\t\t" + firstPrototypeClone.Price);

                    Console.WriteLine("Second: \t" + secondPrototype.Model + "\t\t" + secondPrototype.Price);
                    Console.WriteLine("Clone: \t\t" + secondPrototypeClone.Model + "\t\t" + secondPrototypeClone.Price);
                });

                Depart("Builder", () =>
                {
                    var director = new Creational.Director();
                    var fordBuilder = new Creational.CarBuilder("Ford");
                    var harleyBuilder = new Creational.MotorCycleBuilder("Harley Davidson");

                    director.Construct(fordBuilder);
                    director.Construct(harleyBuilder);

                    var vehicle = fordBuilder.GetVehicle();
                    vehicle.Show();

                    vehicle = harleyBuilder.GetVehicle();
                    vehicle.Show();
                });
            }, true);

            Console.ReadKey();
        }
    }
}
