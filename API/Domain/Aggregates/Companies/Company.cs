using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Aggregates.Companies
{
    public class Company:Entity,IAggregateRoot
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string TeleNo { get; set; }

        public string EmailAddress { get; set; }

        public Company()
        {
        }

        public Company(string name, string address, string teleNo, string emailAddress)
        {
            Name = name;
            Address = address;
            TeleNo = teleNo;
            EmailAddress = emailAddress;
        }
    }
}
