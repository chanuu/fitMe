using MediatR;

namespace API.Commands.Users.CreateUser
{
    public class CreateUserCommand : IRequest<Domain.Aggregates.User.User>
    {
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ContactNumber { get; set; }

        
        public CreateUserCommand(Guid userId, string userName, string fullName, string contactNumber)
        {
            UserId = userId;
            UserName = userName;
            FullName = fullName;
            ContactNumber = contactNumber;

        }
    }
}
