namespace ExamTask2
{
    public class Appetizer : Dish
    {
        public Appetizer(string name, double cost) : base(name, cost)
        {
        }

        public override string ToString()
        {
            return $"Закуска. {base.ToString}";
        }
    }
}
