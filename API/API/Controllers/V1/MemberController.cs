using Microsoft.AspNetCore.Mvc;
using static API.Contract.V1.Routes;

namespace API.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class MemberController : Controller
    {
        [HttpGet(Member.GetAllMembers)]
        public async Task<IActionResult> GetAll()
        {


            return Ok("Say Hellow");
        }

        [HttpGet(Member.Get)]
        public async Task<IActionResult> Get()
        {


            return Ok("Say Hellow");
        }

        [HttpGet(Member.ViewAttendane)]
        public async Task<IActionResult> GetAttendance()
        {


            return Ok("Say Hellow");
        }

        [HttpPut(Member.Disable)]
        public async Task<IActionResult> Delete()
        {


            return Ok("Say Hellow");
        }

        [HttpGet(Member.ViewWorkot)]
        public async Task<IActionResult> Workout()
        {


            return Ok("Say Hellow");
        }
    }
}
