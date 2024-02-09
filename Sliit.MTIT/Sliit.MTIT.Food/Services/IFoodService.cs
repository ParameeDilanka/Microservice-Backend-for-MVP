namespace Sliit.MTIT.Food.Services
{
    public interface IFoodService
    {
        List<Models.Food> GetFoods();
        Models.Food? GetFood(int id);
        Models.Food? AddFood(Models.Food food);
        Models.Food? UpdateFood(Models.Food food);
        bool? DeleteFood(int id);
    }
}
