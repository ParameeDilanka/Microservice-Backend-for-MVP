namespace Sliit.MTIT.Hotel_Bill.Services
{
    public interface IHotel_BillService
    {
        List<Models.Hotel_Bill> GetHotel_Bills();
        Models.Hotel_Bill? GetHotel_Bill(int id);
        Models.Hotel_Bill? AddHotel_Bill(Models.Hotel_Bill hotel_Bill);
        Models.Hotel_Bill? UpdateHotel_Bill(Models.Hotel_Bill hotel_Bill);
        bool? DeleteHotel_Bill(int id);

    }
}
