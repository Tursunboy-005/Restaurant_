using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_
{
    internal class Waiter : User
    {
        public Waiter(string name) : base(name, "Waiter")
        {
        }

        public override void PerformActioon()
        {
            Console.WriteLine("Perform waiter action..");
            TakeOrder();
            ServeFood();
        }

        private void TakeOrder()
        {
            Console.WriteLine("Taking order from customer");
        }

        private void ServeFood()
        {
            Console.WriteLine("Taking food to customer");
        }
    }
}
