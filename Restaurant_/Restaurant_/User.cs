using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_
{
    internal class User
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public User(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public virtual void PerformActioon()
        {
            Console.WriteLine("Performing user action..");
        }
    }
}
