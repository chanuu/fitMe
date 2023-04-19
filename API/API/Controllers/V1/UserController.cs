using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        //get all orders 
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
           

            return Ok("Say Hellow");
        }
    }
}
