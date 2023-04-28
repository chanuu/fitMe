using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Common;

namespace Domain.Aggregates.Companies
{
    
    public class Package : Entity, IAggregateRoot
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsActive { get; set; } = true;

        public double Price { get; set; }


        public Guid CompanyId { get; set; }

        public Package()
        {

        }

        public Package(string name, string description, bool isActive, double price, Guid companyId)
        {
            Name = name;
            Description = description;
            IsActive = isActive;
            Price = price;
            CompanyId = companyId;
        }
    }
}
