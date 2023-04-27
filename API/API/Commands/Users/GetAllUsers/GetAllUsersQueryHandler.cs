using API.Commands.Users.GetUserById;
using Application.Abstraction.Domain.Users;
using AutoMapper;
using Infrastructure.Persistance.Repositories;
using MediatR;

namespace API.Commands.Users.GetAllUsers
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery,List< Domain.Aggregates.User.User>>
    {
        private readonly IUserRepository _UserRepository;


        public GetAllUsersQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _UserRepository = userRepository;

        }

        public async Task<List<Domain.Aggregates.User.User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var users = await _UserRepository.GetAllAsync();
            return users;
        }
        


    }
}
