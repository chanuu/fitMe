using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates.Companies
{
    public class TimeSlot : Entity, IAggregateRoot
    {
        public string Start { get; set; }

        public string End { get; set; }

        public bool IsActive { get; set; } = true;

        public Guid CompanyId { get; set; }

        public TimeSlot(string start, string end, bool isActive, Guid companyId)
        {
            Start = start;
            End = end;
            IsActive = isActive;
            CompanyId = companyId;
        }
    }
}
