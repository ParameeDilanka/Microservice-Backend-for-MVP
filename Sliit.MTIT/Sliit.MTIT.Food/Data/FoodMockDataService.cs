namespace Sliit.MTIT.Food.Data
{
    public class FoodMockDataService
    {
        public static List<Models.Food> Foods = new List<Models.Food>()
        {
            new Models.Food { Id = 1, Name = "Rice and Curry", Description  = "With 3 curries", Price  = 350 },
            new Models.Food { Id = 2, Name = "String Hoppers", Description  = "With Gravy", Price  = 250 },
            new Models.Food { Id = 3, Name = "Noodles", Description = "With egg", Price = 320 },
            new Models.Food { Id = 4, Name = "Fried Rice", Description = "With Chicken devel", Price = 550 },
            new Models.Food { Id = 5, Name = "Lump Rice", Description = "With 5 curry", Price = 790 }
    };
    }
}
