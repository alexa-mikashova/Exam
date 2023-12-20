using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask2
{
    public class Dish
    {
        public string Name { get; set; }
        public double Cost { get; set; }

        public Dish(string name, double cost)
        {
            Name = name;
            Cost = cost;
        }

        public override string ToString()
        {
            return $"Название: {Name}, Цена: {Cost}";
        }
    }
}
