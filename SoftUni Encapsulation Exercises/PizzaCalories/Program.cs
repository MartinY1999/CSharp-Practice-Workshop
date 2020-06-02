using System;

namespace PizzaCalories
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Pizza pizza = Pizza.CreatePizza();

                pizza.Dough = Dough.CreateDough();
                while (true)
                {
                    string input = Console.ReadLine();
                    if (input == "END") break;
                    {
                        pizza.AddTopping(Topping.CreateTopping(input));
                    }
                }

                pizza.PrintTotalCalories();
                Console.ReadLine();
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
