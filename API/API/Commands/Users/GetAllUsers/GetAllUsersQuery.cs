using MediatR;

namespace API.Commands.Users.GetAllUsers
{
    public class GetAllUsersQuery : IRequest<List<Domain.Aggregates.User.User>>
    {
    }
}
