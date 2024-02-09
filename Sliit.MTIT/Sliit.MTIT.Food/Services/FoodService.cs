using Sliit.MTIT.Food.Data;

namespace Sliit.MTIT.Food.Services
{
    public class FoodService : IFoodService
    {
        public List<Models.Food> GetFoods()
        {
            return FoodMockDataService.Foods;
        }

        public Models.Food? GetFood(int id)
        {
            return FoodMockDataService.Foods.FirstOrDefault(x => x.Id == id);
        }

        public Models.Food? AddFood(Models.Food food)
        {
            FoodMockDataService.Foods.Add(food);
            return food;
        }

        public Models.Food? UpdateFood(Models.Food food)
        {
            Models.Food selectedFood = FoodMockDataService.Foods.FirstOrDefault(x => x.Id == food.Id);
            if (selectedFood != null)
            {
                selectedFood.Description = food.Description;
                selectedFood.Price = food.Price;
                selectedFood.Name = food.Name;
                return selectedFood;
            }

            return selectedFood;
        }

        public bool? DeleteFood(int id)
        {
            Models.Food selectedFood = FoodMockDataService.Foods.FirstOrDefault(x => x.Id == id);
            if (selectedFood != null)
            {
                FoodMockDataService.Foods.Remove(selectedFood);
                return true;
            }
            return false;
        }
    }
}
