using System;
using API.Commands.Users.GetUserById;
using Application.Abstraction.Domain.Users;
using Domain.Aggregates.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Commands.Users.DeleteUser
{
public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommand, Domain.Aggregates.User.User>

    {
        private readonly IUserRepository _userRepository;

        public DeleteUserCommandHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<Domain.Aggregates.User.User> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _userRepository.GetAsync(request.Id);
            if (user == null)
            {
                return null;
            }

            _userRepository.Remove(user);
            await _userRepository.UnitOfWork.SaveChangesAsync(cancellationToken);

            return user;
        }
    }
    
}