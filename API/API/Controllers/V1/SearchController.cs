using Microsoft.AspNetCore.Mvc;
using static API.Contract.V1.Routes;

namespace API.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : Controller
    {
        [HttpPost(SearchAPI.SearchGym)]
        public async Task<IActionResult> Gym()
        {


            return Ok("Say Hellow");
        }

        [HttpPost(SearchAPI.SearchPackge)]
        public async Task<IActionResult> Packge()
        {


            return Ok("Say Hellow");
        }


        [HttpPost(SearchAPI.Instructor)]
        public async Task<IActionResult> Instrucor()
        {


            return Ok("Say Hellow");
        }


        [HttpPost(SearchAPI.Workout)]
        public async Task<IActionResult> Workout()
        {


            return Ok("Say Hellow");
        }
    }
}
