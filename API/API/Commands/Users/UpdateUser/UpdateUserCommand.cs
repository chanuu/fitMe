using MediatR;

namespace API.Commands.Users.UpdateUser
{
    public class UpdateUserCommand : IRequest<Domain.Aggregates.User.User>
    {
        public Guid UserId { get; set; }

        public Guid Id { get; set; }

        public string UserName { get; set; }

        public string FullName { get; set; }

        public string ContactNumber { get; set; }

    }
}
