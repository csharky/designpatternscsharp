using System;

namespace DesignPatternsExample
{
    class Program
    {
        private static void DepartPattern(string name, System.Action action)
        {
            var firstLine = "--------- " + name + " Example ---------";
            Console.WriteLine(firstLine);

            action();

            for (int i = 0; i < firstLine.Length; i++)
                Console.Write("-");
        }

        static void Main(string[] args)
        {
            DepartPattern("Singleton", () =>
            {
                var content = Creational.Singleton.Instance.GetContent();
                Console.WriteLine(content);
            });

            Console.ReadKey();
        }
    }
}
