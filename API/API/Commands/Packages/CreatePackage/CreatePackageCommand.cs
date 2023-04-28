using MediatR;

namespace API.Commands.Packages.CreatePackage
{
    public class CreatePackageCommand : IRequest<Domain.Aggregates.Companies.Package>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public double Price { get; set; }


        public Guid CompanyId { get; set; }

        
        public CreatePackageCommand(string name, string description, bool isActive, double price, Guid companyId)
        {
            Name = name;
            Description = description;
            IsActive = isActive;
            Price = price;
            CompanyId = companyId;
        }


    }
}
