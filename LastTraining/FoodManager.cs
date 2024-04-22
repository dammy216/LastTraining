using System.Collections.Generic;

namespace LastTraining
{
    public class FoodManager
    {
        private List<Food> _foods = new List<Food>();

        public List<Food> Foods { get { return _foods; } }

        public void Add(Food food)
        {
            _foods.Add(food);
        }
    }
}
