using Application.Abstraction.Domain.Users;
using Domain.Aggregates.User;
using MediatR;

namespace API.Commands.Users.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Domain.Aggregates.User.User>
    {
        private readonly IUserRepository _userRepository;

        public UpdateUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Unit> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            
               var user = await _userRepository.GetAsync(request.UserId);

                if (user == null)
                {
                    throw new Exception();
                }

            user.UserName = request.UserName;
            user.FullName = request.FullName;
            user.ContactNumber = request.ContactNumber;

            _userRepository.Update(user);
            await _userRepository.UnitOfWork.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
