using MediatR;

namespace API.Commands.CompanyConfigurations.UpdateCompanyConfiguration
{
    public class UpdateCompanyConfigurationCommand : IRequest<Domain.Aggregates.Companies.CompanyConfiguration>
    {
        public Guid Id { get; set; }
        public string OpenTime { get; set; }
        public string CloseTime { get; set; }
        public int TimeSlotLength { get; set; }
        public int MaximumCapacity { get; set; }

        public UpdateCompanyConfigurationCommand(Guid id, string openTime, string closeTime, int timeSlotLength, int maximumCapacity)
        {
            Id = id;
            OpenTime = openTime;
            CloseTime = closeTime;
            TimeSlotLength = timeSlotLength;
            MaximumCapacity = maximumCapacity;
        }
    }
}
