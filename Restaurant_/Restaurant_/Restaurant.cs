using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_
{
    internal class Restaurant
    {
        private List<User> users;
        private List<Food> menu;

        public Restaurant()
        {
            users = new List<User>();
            menu = new List<Food>();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }
        public void RemoveUser(User user)
        {
            users.Remove(user);
        }
        public void AddFoodToMenu(Food food)
        {
            menu.Add(food);
        }
        public void RemoveFoodFromMenu(Food food)
        {
            menu.Remove(food);
        }
        public void Start()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Welcome to the Restaurant Managment System!");
            Console.WriteLine("-------------------------------------------");
            Console .ForegroundColor = ConsoleColor.White;

            while (true)
            {
                Console.WriteLine("1. Add User");
                Console.WriteLine("2. Remove User");
                Console.WriteLine("3. Add Food to Menu");
                Console.WriteLine("4. Remove Food from Menu");
                Console.WriteLine("5. Perform Actions");
                Console.WriteLine("6. View Menu");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddUserMenu();
                        break;
                    case 2:
                        RemoveUserMenu();
                        break;
                    case 3:
                        AddFoodToMenu();
                        break;
                    case 4:
                        RemoveFoodFromMenu();
                        break;
                    case 5:
                        PerformActions();
                        break;
                    case 6:
                        ViewMenu();
                        break;
                    case 7:
                        Console.WriteLine("Exiting the application....");
                        return;
                    default:
                        Console.WriteLine("Invalid choice! Please try again.");
                        break;
                }
            }
        }

        private void AddUserMenu()
        {
            Console.WriteLine("Select the user type: ");
            Console.WriteLine("1. Waiter");
            Console.WriteLine("2. Chef");
            Console.Write("Enter your choice: ");
            int userType = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the user's name: ");
            string userName = Console.ReadLine();

            switch (userType)
            {
                case 1:
                    User waiter = new Waiter(userName);
                    AddUser(waiter);
                    Console.WriteLine($"Waiter {userName} added successfully!");
                    break;
                case 2:
                    User chef = new Chef(userName);
                    AddUser(chef);
                    Console.WriteLine($"Chef {userName} added successfully!");
                    break;
                default:
                    Console.WriteLine("Invalid user type! Please try again.");
                    break;
            }
        }

        private void RemoveUserMenu()
        {
            if(users.Count == 0)
            {
                Console.WriteLine("No user to remove!");
                return;
            }

            Console.WriteLine("Select the user to remove: ");
            for (int i = 0; i < users.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i + 1}.{users[i].Name}({users[i].Role})");
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write("Enter your choice: ");
            int userIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if(userIndex >= 0 && userIndex < users.Count)
            {
                User removeUser = users[userIndex];
                RemoveUser(removeUser);
                Console.WriteLine($"{removeUser.Role}{removeUser.Name} removed successfully!");
            }
            else
            {
                Console.WriteLine("Invalid user choice! Please try again.");
            }
        }

        private void AddFoodToMenu()
        {
            Console.Write("Enter the food name: ");
            string foodName = Console.ReadLine();

            Console.Write("Enter the food Price: ");
            decimal foodprice = Convert.ToDecimal(Console.ReadLine());
            Food food = new Food(foodName, foodprice);
            AddFoodToMenu(food);
            Console.WriteLine($"Food {food.Name} added to the menu successfully");
        }

        private void RemoveFoodFromMenu()
        {
            if (menu.Count == 0)
            {
                Console.WriteLine("No food items in the menu!");
                return;
            }
            Console.WriteLine("Select the food items to remove: ");
            for (int i = 0; i < menu.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{i + 1}.{menu[i].Name}");
                Console.ForegroundColor= ConsoleColor.White;
            }

            Console.Write("Enter your choice: ");
            int foodIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (foodIndex >= 0 && foodIndex < menu.Count)
            {
                Food removeFood = menu[foodIndex];
                RemoveFoodFromMenu(removeFood);
                Console.WriteLine($"{removeFood.Name} removed from the menu successfully!");
            }
            else
            {
                Console.WriteLine("Invalid food choice! Please try again.");
            }
        }

        private void PerformActions()
        {
            if (users.Count == 0)
            {
                Console.WriteLine("No users available to performaction!");
                return;
            }

            Console.WriteLine("Select the user to performactions: ");
            for (int i = 0; i < users.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{users[i].Name}({users[i].Role})");
            }

            Console.Write("Enter yoour chice: ");
            int userIndex = Convert.ToInt32(Console.ReadLine()) - 1;

            if (userIndex >= 0 && userIndex < users.Count)
            {
                User selectedUser = users[userIndex];
                Console.WriteLine($"Selected user: {selectedUser.Name}({selectedUser.Role})");

                selectedUser.PerformActioon();
            }
            else
            {
                Console.WriteLine("Invalid user choice! Please try again.");
            }
        }

        private void ViewMenu()
        {
            if(menu.Count == 0)
            {
                Console.WriteLine("No food items in the menu");
                return;
            }

            Console.WriteLine("Menu: ");
            foreach (Food food in menu)
            {
                food.DispllayDetails();
                Console.WriteLine();
            }
        }
    }
}
