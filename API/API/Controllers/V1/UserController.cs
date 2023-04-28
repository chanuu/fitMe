using API.Commands.Company.CreateCompanies;
using API.Commands.Users.CreateUser;
using API.Commands.Users.GetAllUsers;
using API.Commands.Users.GetUserById;
using API.Commands.Users.UpdateUser;
using API.Contract.V1;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UsersController(ILogger<UsersController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }
        

        [HttpGet(Routes.Users.Get)]
        public async Task<IActionResult> Get(Guid Id)
        {
            var user = new GetUserByIdQuery { UserId = Id };
            var userId = await _mediator.Send(user);

            if (userId == null)
            {
                return NotFound();
            }

            return Ok(userId);
        }

        //Create new user 
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            var user = await _mediator.Send(command);


            return Ok(user);

        }

        [HttpGet(Routes.Users.GetAll)]
        public async Task<IActionResult> GetAllUsers()
        {

            var user = new GetAllUsersQuery();
            var userId = await _mediator.Send(user);

            if (userId == null)
            {
                return NotFound();
            }

            return Ok(userId);

        }

        [HttpPut("id")]
        public async Task<IActionResult> UpdateUser(Guid id, UpdateUserCommand command)
        {
            if (id != command.UserId)
            {
                return BadRequest();
            }

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
