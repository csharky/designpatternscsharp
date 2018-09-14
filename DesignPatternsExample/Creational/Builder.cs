using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExample.Creational
{
    interface IBuilder
    {
        void StartUpOperations();
        void BuildBody();
        void InsertWheels();
        void AddHeadlights();
        void EndOperations();
        Product GetVehicle();
    }

    class CarBuilder : IBuilder
    {
        private string brandName;
        private Product product;

        public CarBuilder(string brand)
        {
            product = new Product();
            brandName = brand;
        }

        public void StartUpOperations()
        {
            product.Add(string.Format("Car Model name: {0}", brandName));
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }

        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }

        public void EndOperations()
        {
        }

        public Product GetVehicle()
        {
            return product;
        }
    }

    class MotorCycleBuilder : IBuilder
    {
        private string brandName;
        private Product product;

        public MotorCycleBuilder(string brand)
        {
            product = new Product();
            this.brandName = brand;
        }

        public void StartUpOperations()
        {
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Motorcycle");
        }

        public void InsertWheels()
        {
            product.Add("2 wheels are added");
        }

        public void AddHeadlights()
        {
            product.Add("1 Headlights are added");
        }
        public void EndOperations()
        {
            product.Add(string.Format("Motorcycle Model name: {0}", brandName));
        }
        public Product GetVehicle()
        {
            return product;
        }
    }

    class Product
    {
        private LinkedList<string> parts;
        public Product()
        {
            parts = new LinkedList<string>();
        }
        public void Add(string part)
        {
            parts.AddLast(part);
        }
        public void Show()
        {
            Console.WriteLine("Product completed as below: ");
            foreach (string part in parts)
                Console.WriteLine(part);

            Console.WriteLine("");
        }
    }

    class Director
    {
        IBuilder builder;
        public void Construct(IBuilder builder)
        {
            this.builder = builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}
