using API.Commands.Company.CreateCompanies;
using API.Commands.Users.CreateUser;
using API.Commands.Users.DeleteUser;
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

        //Get user by Id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetUserByIdQuery { id = id };
            var user = await _mediator.Send(query);

            return user != null ? Ok(user) : NotFound("Cannot Find User Related to the Given Id");
        }

        //Create new user 
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateUserCommand command)
        {
            var user = await _mediator.Send(command);


            return Ok(user);

        }

        //Get all users
        [HttpGet(Routes.Users.GetAll)]
        public async Task<IActionResult> GetAllUsers()
        {

            var query = new GetAllUsersQuery();
            var user = await _mediator.Send(query);

            return user != null ? Ok(user) : NotFound("Cannot Find User Related to the Given Id");

        }

        //Update user by id
        [HttpPut("id")]
        public async Task<IActionResult> UpdateUser( [FromBody] UpdateUserCommand command)
        {
           
            var user = await _mediator.Send(command);

            return user != null ? Ok(user) : NotFound("Cannot Find User Related to the Given Id");
        }

        // Delete user by id
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(Guid id)
        {
            var command = new DeleteUserCommand { Id = id };
            var user = await _mediator.Send(command);

            return user != null ? Ok(user) : NotFound("Cannot Find User Related to the Given Id");
        }
            
    }
}
