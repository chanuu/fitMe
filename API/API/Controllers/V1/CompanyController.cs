using API.Commands.Company.CreateCompanies;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V1
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : ControllerBase
    {
        private readonly ILogger<CompanyController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CompanyController(ILogger<CompanyController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        //get all orders 
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {


            return Ok("Say Hellow");
        }

        //get all orders 
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCompanyCommand command)
        {
            var company = await _mediator.Send(command);
           

            return Ok(company);

        }
    }
}
