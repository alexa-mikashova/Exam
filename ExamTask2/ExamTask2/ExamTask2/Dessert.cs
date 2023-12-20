using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask2
{
    public class Dessert : Dish
    {
        public Dessert(string name, double cost) : base(name, cost)
        {
        }

        public override string ToString()
        {
            return $"Десерт. {base.ToString}";
        }
    }
}
