using System.Collections.Generic;
using Trial_Shop.Models;

namespace Trial_Shop.Interfaces
{
    public interface IUserRepository
    {
        List<UserModel> GetAllUsers();
        UserModel GetUser(string email, string password);
    }
}
