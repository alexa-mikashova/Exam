using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTask2
{
    public class MainCourse : Dish
    {
        public bool WithGarnish { get; set; }
        public MainCourse(string name, double cost) : base(name, cost)
        {
        }

        public MainCourse(string name, double cost, bool withGarnish) : base(name, cost)
        {
            WithGarnish = withGarnish;
        }

        public override string ToString()
        {
            return $"Основное блюдо. {base.ToString}, Гарнир: {(WithGarnish ? "Да" : "Нет")}";
        }
    }
}
