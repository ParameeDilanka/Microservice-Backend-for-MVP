namespace Sliit.MTIT.Hotel_Bill.Data
{
    public static class Hotel_BillMockDataService
    {
        public static List<Models.Hotel_Bill> Hotel_Bills = new List<Models.Hotel_Bill>()
        {
            new Models.Hotel_Bill { Id = 1, Name = "John", Type = "Cash", Amount = 200000 },
            new Models.Hotel_Bill { Id = 2, Name = "Mary", Type = "Credit card", Amount = 150000 },
            new Models.Hotel_Bill { Id = 3, Name = "Tom", Type = "Traveller's check", Amount = 10000 },
            new Models.Hotel_Bill { Id = 4, Name = "Kate", Type = "Bill-to account", Amount = 250000 },
            new Models.Hotel_Bill { Id = 5, Name = "Mike", Type = "Personal check", Amount = 30000 }
        };

    }
}
