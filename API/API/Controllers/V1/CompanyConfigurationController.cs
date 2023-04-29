using API.Commands.CompanyConfigurations.CreateCompanyConfiguration;
using API.Commands.CompanyConfigurations.DeleteCompanyConfiguration;
using API.Commands.CompanyConfigurations.GetAllCompanyConfigurations;
using API.Commands.CompanyConfigurations.GetCompanyConfigurationById;
using API.Commands.CompanyConfigurations.UpdateCompanyConfiguration;
using API.Commands.Users.CreateUser;
using API.Commands.Users.DeleteUser;
using API.Commands.Users.GetAllUsers;
using API.Commands.Users.GetUserById;
using API.Commands.Users.UpdateUser;
using API.Contract.V1;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace API.Controllers.V1
{
   
    [ApiController]
    [Route("[controller]")]
    public class CompanyConfigurationController : ControllerBase
    {
        private readonly ILogger<CompanyConfigurationController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CompanyConfigurationController(ILogger<CompanyConfigurationController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }


        //Create Company Configuration
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateCompanyConfigurationCommand command)
        {
            var user = await _mediator.Send(command);


            return Ok(user);

        }

        //Get all Company Configurations 
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCompanyConfigurations()
        {

            var companyConfig = new GetAllCompanyConfigurationQuery();
            var companyConfiguration = await _mediator.Send(companyConfig);

            if (companyConfiguration == null)
            {
                return NotFound("Can not find Id");
            }

            return Ok(companyConfiguration);

        }

        //Get Company Configurations  by Id
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var query = new GetCompanyConfigurationByIdQuery { id = id };
            var companyConfig= await _mediator.Send(query);

            if (companyConfig == null)
            {
                return NotFound("Can not find given Id");
            }

            return Ok(companyConfig);
        }


        //Update company configuration
        [HttpPut("id")]
        public async Task<ActionResult<Domain.Aggregates.Companies.CompanyConfiguration>> UpdateCompanyConfiguration([FromBody] UpdateCompanyConfigurationCommand command)
        {

            var companyConfig = await _mediator.Send(command);

            if (companyConfig == null)
            {
                return NotFound("Can not find Id");

            }

            return Ok(companyConfig);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompanyConfiguration(Guid id)
        {
            var command = new DeleteCompanyConfigurationCommand { Id = id };
            var companyConfig = await _mediator.Send(command);

            return companyConfig != null ? Ok(companyConfig) : NotFound("Cannot Find Given Id");
        }
    }
}
