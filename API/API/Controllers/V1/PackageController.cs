using API.Commands.CompanyConfigurations.UpdateCompanyConfiguration;
using API.Commands.Packages.CreatePackage;
using API.Commands.Packages.DeletePackage;
using API.Commands.Packages.GetAllPackage;
using API.Commands.Packages.GetPackageById;
using API.Commands.Packages.UpdatePackage;
using API.Commands.Users.CreateUser;
using API.Commands.Users.DeleteUser;
using API.Commands.Users.GetAllUsers;
using API.Commands.Users.GetUserById;
using API.Contract.V1;
using AutoMapper;
using Domain.Aggregates.Companies;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers.V1
{

    [ApiController]
    [Route("[controller]")]
    public class PackageController : ControllerBase
    {

        private readonly ILogger<PackageController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public PackageController(ILogger<PackageController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        //Create new package 
        [HttpPost ("Create")]
        public async Task<IActionResult> Create([FromBody] CreatePackageCommand command)
        {
            var package = await _mediator.Send(command);


            return Ok(package);

        }

        //Get all packages
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllPackages()
        {

            var query = new GetAllPackageQuery();
            var package = await _mediator.Send(query);

            return package != null ? Ok(package) : NotFound("Cannot Find Given Id");

        }

        //Get package by Id
        [HttpGet("{Id}")]
        public async Task<IActionResult> Get(Guid Id)
        {
            var query = new GetPackageByIdQuery { Id = Id };
            var package = await _mediator.Send(query);

            return package != null ? Ok(package) : NotFound("Cannot Find Given Id");
        }

        //Update package
        [HttpPut("id")]
        public async Task<ActionResult<Domain.Aggregates.Companies.Package>> UpdatePackage([FromBody] UpdatePackageCommand command)
        {

            var package = await _mediator.Send(command);

            return package != null ? Ok(package) : NotFound("Cannot Find  Given Id");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletepackage(Guid id)
        {
            var command = new DeletePackageCommand { Id = id };
            var package = await _mediator.Send(command);

            return package != null ? Ok(package) : NotFound("Cannot Find User Related to the Given Id");
        }


    }
}
