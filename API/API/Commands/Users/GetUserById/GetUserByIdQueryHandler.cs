using API.Commands.Users.CreateUser;
using Application.Abstraction.Domain.Users;
using AutoMapper;
using MediatR;

namespace API.Commands.Users.GetUserById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Domain.Aggregates.User.User>
    {
        private readonly IUserRepository _UserRepository;
        

        public GetUserByIdQueryHandler(IUserRepository userRepository, IMapper mapper)
        {
            _UserRepository = userRepository;
            
        }

        public async Task<Domain.Aggregates.User.User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _UserRepository.GetAsync(request.id);

            return user;
        }
        

    }
}
