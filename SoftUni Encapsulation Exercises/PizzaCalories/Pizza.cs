using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private Dough dough;
        private List<Topping> topping;
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length > 15)
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                name = value;
            }
        }
        public Dough Dough
        {
            get => dough;
            set => dough = value;
        }
        public List<Topping> Topping
        {
            get => topping;
            set => topping = value;
        }
        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            Topping = new List<Topping>();
        }
        public static Pizza CreatePizza()
        {
            string[] parts = Console.ReadLine().Split(' ');
            return new Pizza(parts[1], new Dough());
        }
        public void PrintTotalCalories()
        {
            double totalToppCals = 0;
            foreach (Topping top in this.Topping)
            {
                totalToppCals += top.ToppingCalories();
            }
            double totalCalories = this.Dough.DoughCalories() + totalToppCals;
            Console.WriteLine($"{this.Name} - {totalCalories:F2} Calories.");
        }
        public List<Topping> AddTopping(Topping current)
        {
            if (this.Topping.Count + 1 > 10)
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            else
                this.Topping.Add(current);
            return this.Topping;
        }
    }
}
