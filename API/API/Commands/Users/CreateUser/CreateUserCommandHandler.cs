using API.Commands.Company.CreateCompanies;
using Application.Abstraction.Domain.Companies;
using Application.Abstraction.Domain.Users;
using Infrastructure.Persistance.Repositories;
using MediatR;

namespace API.Commands.Users.CreateUser
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, Domain.Aggregates.User.User>
    {
        private readonly IUserRepository _UserRepository;

        public CreateUserCommandHandler(IUserRepository userRepository)
        {
            _UserRepository = userRepository;
        }

        public async Task<Domain.Aggregates.User.User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            Domain.Aggregates.User.User user = new
            Domain.Aggregates.User.User(request.UserId, request.UserName, request.FullName, request.ContactNumber);
            _UserRepository.Add(user);
            await _UserRepository.UnitOfWork.SaveChangesAsync();
            return user;
        }
    }


}
