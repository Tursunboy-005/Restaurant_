namespace Restaurant_
{
    internal class Program
    {
        delegate void RestaurantEvent();
        static void Main(string[] args)
        {
            Restaurant restaurant = new Restaurant();
            restaurant.Start();
        }
    }
}