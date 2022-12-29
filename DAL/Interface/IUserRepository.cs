using DomainEntity.Models;
using ELM.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IUserRepository
    { 
        Task AddUser(UserRegistrationModel userRegistrationModel);
        Task<bool> DeleteUser(string id);
        List<User> GetAllUser();
        Task<string> SignIn(SignIn signIn);
        Task SignOut();
        Task<bool> UpdateUser(User user);
    }
}
