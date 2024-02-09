using Microsoft.AspNetCore.Mvc;
using Sliit.MTIT.Food.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Sliit.MTIT.Food.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService ?? throw new ArgumentNullException(nameof(foodService));
        }


        /// <summary>
        /// Get all foods
        /// </summary>
        /// <returns>return the list of foods</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_foodService.GetFoods());
        }

        /// <summary>
        /// Get food by ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Return the food with the passed ID</returns>
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return _foodService.GetFood(id) != null ? Ok(_foodService.GetFood(id)) : NoContent();
        }

        /// <summary>
        /// Add foods
        /// </summary>
        /// <param name="food"></param>
        /// <returns>Return the added food</returns>
        [HttpPost]
        public IActionResult Post([FromBody] Models.Food food)
        {
            return Ok(_foodService.AddFood(food));
        }

        /// <summary>
        /// Update the food
        /// </summary>
        /// <param name="food"></param>
        /// <returns>Return the updated food</returns>
        [HttpPut]
        public IActionResult Put([FromBody] Models.Food food)
        {
            return Ok(_foodService.UpdateFood(food));
        }

        /// <summary>
        /// Delete the food with the passed ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _foodService.DeleteFood(id);

            return result.HasValue & result == true ? Ok($"food with ID:{id} got deleted successfully.")
                : BadRequest($"Unable to delete the food with ID:{id}.");
        }
    }
}
