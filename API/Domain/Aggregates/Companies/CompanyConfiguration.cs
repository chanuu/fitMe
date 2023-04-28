using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Aggregates.Companies
{
    public class CompanyConfiguration : Entity, IAggregateRoot
    {
        public string OpenTime { get; set; }

        public string CloseTime { get; set; }

        public int TimeSlotLength { get; set; }

        public int MaximumCapacity { get; set; }


        public CompanyConfiguration()
        {

        }
        public CompanyConfiguration(string openTime, string closeTime, int timeSlotLength, int maximumCapacity)
        {
            OpenTime = openTime;
            CloseTime = closeTime;
            TimeSlotLength = timeSlotLength;
            MaximumCapacity = maximumCapacity;
        }

    }
}
