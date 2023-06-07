using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_
{
    internal class Food
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Food(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public void DispllayDetails()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Food: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.ForegroundColor= ConsoleColor.White;
        }
    }
}
