using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_
{
    internal class Chef : User
    {
        public Chef(string name) : base(name,"Chef") 
        {
        }

        public override void PerformActioon()
        {
            Console.WriteLine("Performing chef action");
            PrepareFood();
            CookFood();
        }

        private void PrepareFood()
        {
            Console.WriteLine("Preparing food");
        }

        private void CookFood()
        {
            Console.WriteLine("Cooking food");
        }
    }
}
