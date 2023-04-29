using MediatR;

namespace API.Commands.Users.DeleteUser
{
    
    public class DeleteUserCommand : IRequest<Domain.Aggregates.User.User>
    {
        public Guid Id { get; set; }
    }

}
