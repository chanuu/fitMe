using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Abstraction.Platfrom.Common;
using Domain.Aggregates.Companies;
using Domain.Aggregates.User;

namespace Application.Abstraction.Domain.Users
{
    public interface IUserRepository : IRepository<User>, ITransientService
    {
        User Add(User user);
        Task<User> ConfirmAsync(Guid userId);

        Task<List<User>> GetAllAsync();

        void Update(User user);      
        Task<User> GetAsync(Guid companyId);

        void Remove(User user);


    }
}
