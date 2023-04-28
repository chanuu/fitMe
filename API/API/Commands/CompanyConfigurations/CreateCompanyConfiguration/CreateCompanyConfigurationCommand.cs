using MediatR;

namespace API.Commands.CompanyConfigurations.CreateCompanyConfiguration
{
    
    public class CreateCompanyConfigurationCommand : IRequest<Domain.Aggregates.Companies.CompanyConfiguration>
    {
        public string OpenTime { get; set; }

        public string CloseTime { get; set; }

        public int TimeSlotLength { get; set; }

        public int MaximumCapacity { get; set; }



        public CreateCompanyConfigurationCommand(string openTime, string closeTime, int timeSlotLength, int maximumCapacity)
        {
            OpenTime = openTime;
            CloseTime = closeTime;
            TimeSlotLength = timeSlotLength;
            MaximumCapacity = maximumCapacity;
        }

    }
}
