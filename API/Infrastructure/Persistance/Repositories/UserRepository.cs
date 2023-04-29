using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction.Domain.Users;
using Application.Abstraction.Platfrom;
using Domain.Aggregates.User;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistance.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiContext _context;

        public IUnitofWork UnitOfWork
        {
            get { return _context; }
        }

        public UserRepository (ApiContext context) 
        { 
            _context = context;
        }

        public User Add(User user)
        {
            _context.Add(user);
            return user; 
        }

        public Task<User> ConfirmAsync(Guid userId) 
        { 
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.User.ToListAsync();

        }

        public async Task<User> GetAsync(Guid UserId)
        {
            return await _context.User.FirstOrDefaultAsync(o => o.Id == UserId);

        }

        public void Remove(User user)
        { 
            _context.User.Remove(user);
        }

        public void Update(User user)
        {
            _context.User.Update(user);
        }

    }
}
