using Domain.Aggregates.Companies;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Company.CreateCompanies

{
    public class CreateCompanyCommand : IRequest<Domain.Aggregates.Companies.Company>
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public string TeleNo { get; set; }

        public string EmailAddress { get; set; }

        public CreateCompanyCommand(string name, string address, string teleNo, string emailAddress)
        {
            Name = name;
            Address = address;
            TeleNo = teleNo;
            EmailAddress = emailAddress;
        }
    }
}
