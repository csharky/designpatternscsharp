using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExample.Creational
{
    public sealed class Singleton
    {
        private static readonly Singleton instance = new Singleton();
        private string content = "Some content inside the singleton";

        private Singleton()
        {
            Console.WriteLine("Singleton has been instanced inside the private contsruct");
        }

        public static Singleton Instance
        {
            get { return instance; }
        }

        public string GetContent()
        {
            return content;
        }
    }
}
