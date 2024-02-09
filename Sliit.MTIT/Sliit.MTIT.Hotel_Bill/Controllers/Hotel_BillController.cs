using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Hotel_Bill.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Hotel_Bill.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Hotel_BillController : ControllerBase
    {
        private readonly IHotel_BillService _hotel_BillService;

        public Hotel_BillController(IHotel_BillService hotel_BillService)
        {
            _hotel_BillService = hotel_BillService ?? throw new ArgumentNullException(nameof(hotel_BillService));
        }


        /// <summary>
        /// Get all Hotel_Bill
        /// </summary>
        /// <returns>return the list of Hotel_Bills</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_hotel_BillService.GetHotel_Bills());
        }

        /// <summary>
        /// Get Hotel_Bill by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the Hotel_Bill with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _hotel_BillService.GetHotel_Bill(id) != null ? Ok(_hotel_BillService.GetHotel_Bill(id)) : NoContent();
        }

        /// <summary>
        /// Add Hotel_Bills
        /// </summary>
        /// <param name="hotel_Bill"></param>
        /// <returns>Return the added hotel_Bill</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Hotel_Bill hotel_Bill)
        {
            return Ok(_hotel_BillService.AddHotel_Bill(hotel_Bill));
        }

        /// <summary>
        /// Update the Hotel_Bill
        /// </summary>
        /// <param name="Hotel_Bill"></param>
        /// <returns>Return the updated Hotel_Bill</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Hotel_Bill hotel_Bill)
        {
            return Ok(_hotel_BillService.UpdateHotel_Bill(hotel_Bill));
        }

        /// <summary>
        /// Delete the Hotel_Bill with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _hotel_BillService.DeleteHotel_Bill(id);

            return result.HasValue & result == true ? Ok($"hotel_Bill with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the hotel_Bill with ID:{id}.");
        }
    }
}
