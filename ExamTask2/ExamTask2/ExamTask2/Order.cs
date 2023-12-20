namespace ExamTask2
{
    public class Order
    {
        private List<Dish> _dishes;

        public Order()
        {
            _dishes = new List<Dish>();
        }

        public void ReadOrderFromConsole()
        {
            Console.WriteLine("Выберете тип блюда:");
            Console.WriteLine("1 - Основное");
            Console.WriteLine("2 - Закуски");
            Console.WriteLine("3 - Напиток");
            Console.WriteLine("4 - Десерт");

            bool success = int.TryParse(Console.ReadLine(), out int type);
           // if ()
        }

        public void AddDish(Dish dish)
        {
            _dishes.Add(dish);
        }

        public double CalculateCost()
        {
            double result = 0;
            bool withDesert = false;
            foreach (var dish in _dishes)
            {
                result += dish.Cost;
                if (dish is Dessert)
                {
                    withDesert = true;
                }
            }

            if (withDesert)
            {
                result = result * 0.9;
            }

            return result;
        }
    }
}
