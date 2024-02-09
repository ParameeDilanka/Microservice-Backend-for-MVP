using Sliit.MTIT.Hotel_Bill.Data;

namespace Sliit.MTIT.Hotel_Bill.Services
{
    public class Hotel_BillService : IHotel_BillService
    {
        public List<Models.Hotel_Bill> GetHotel_Bills()
        {
            return Hotel_BillMockDataService.Hotel_Bills;
        }

        public Models.Hotel_Bill? GetHotel_Bill(int id)
        {
            return Hotel_BillMockDataService.Hotel_Bills.FirstOrDefault(x => x.Id == id);
        }

        public Models.Hotel_Bill? AddHotel_Bill(Models.Hotel_Bill hotel_Bill)
        {
            Hotel_BillMockDataService.Hotel_Bills.Add(hotel_Bill);
            return hotel_Bill;
        }

        public Models.Hotel_Bill? UpdateHotel_Bill(Models.Hotel_Bill hotel_Bill)
        {
            Models.Hotel_Bill selectedHotel_Bill = Hotel_BillMockDataService.Hotel_Bills.FirstOrDefault(x => x.Id == hotel_Bill.Id);
            if (selectedHotel_Bill != null)
            {
                selectedHotel_Bill.Type = hotel_Bill.Type;
                selectedHotel_Bill.Amount = hotel_Bill.Amount;
                selectedHotel_Bill.Name = hotel_Bill.Name;
                return selectedHotel_Bill;
            }

            return selectedHotel_Bill;
        }

        public bool? DeleteHotel_Bill(int id)
        {
            Models.Hotel_Bill selectedHotel_Bill = Hotel_BillMockDataService.Hotel_Bills.FirstOrDefault(x => x.Id == id);
            if (selectedHotel_Bill != null)
            {
                Hotel_BillMockDataService.Hotel_Bills.Remove(selectedHotel_Bill);
                return true;
            }
            return false;
        }
    }
}
