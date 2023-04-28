using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Domain.Common;

namespace Domain.Aggregates.User
{
    public class User : Entity,IAggregateRoot
    {
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ContactNumber { get; set; }

        public User()
        {
        }
        public User(Guid userId, string userName, string fullName, string contactNumber)
        {
            UserId = userId;
            UserName = userName;
            FullName = fullName;
            ContactNumber = contactNumber;

        }

    }
}
