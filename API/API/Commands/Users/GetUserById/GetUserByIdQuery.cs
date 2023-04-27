using MediatR;

namespace API.Commands.Users.GetUserById
{
    public class GetUserByIdQuery : IRequest<Domain.Aggregates.User.User>
    {
        public Guid UserId { get; set; }
    }
}
