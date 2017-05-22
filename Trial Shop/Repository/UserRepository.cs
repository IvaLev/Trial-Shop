using System.Collections.Generic;
using System.Linq;
using Trial_Shop.Interfaces;
using Trial_Shop.Repository.DataBase;

namespace Trial_Shop.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(ShopModel context) : base(context)
        {
        }

        private Models.UserModel Convert(User user)
        {
            if (user == null)
            {
                return null;
            }

            return new Models.UserModel()
            {
                UserId = user.UserId,
                FirstName = user.FirstName,
                SurName = user.Surname,
                Email = user.Email
            };
        }

        public List<Models.UserModel> GetAllUsers()
        {
            return Context.Users.Select(Convert).ToList();
        }

        public Models.UserModel GetUser(string email, string password)
        {
            var user = Context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user == null)
            {
                return null;
            }
            return Convert(user);
        }
    }
}
