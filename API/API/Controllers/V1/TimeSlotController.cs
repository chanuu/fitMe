using Microsoft.AspNetCore.Mvc;
using static API.Contract.V1.Routes;

namespace API.Controllers.V1
{

    [ApiController]
    [Route("[controller]")]
    public class TimeSlotController : Controller
    {
        [HttpPost(TimeSlots.ReserveTimeSlot)]
        public async Task<IActionResult> Reserve(Guid Id)
        {


            return Ok("Say Hellow");
        }

        [HttpGet(TimeSlots.GetAvaibleTimeSlots)]
        public async Task<IActionResult> Get(Guid Id)
        {


            return Ok("Say Hellow");
        }


        [HttpGet(TimeSlots.GetBookedTimeSlots)]
        public async Task<IActionResult> GetBookedTimeSlots(Guid Id)
        {


            return Ok("Say Hellow");
        }

        [HttpGet(TimeSlots.GetAllTimeSlots)]
        public async Task<IActionResult> GetAll()
        {


            return Ok("Say Hellow");
        }


    }
}
