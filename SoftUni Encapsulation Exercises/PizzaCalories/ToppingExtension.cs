namespace PizzaCalories
{
    public static class ToppingExtension
    {
        public static double ReturnModifier(Topping current)
        {
            double modifier = 2;
            switch (current.Type.ToLower())
            {
                case "meat":
                    modifier = 1.2;
                    break;
                case "veggies":
                    modifier = 0.8;
                    break;
                case "cheese":
                    modifier = 1.1;
                    break;
                case "sauce":
                    modifier = 0.9;
                    break;
                default:
                    break;
            }
            return modifier;
        }
    }
}
