using Models;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer
{
    public class UserRegistrationRL
    {
        private static List<UserModel> _users = new List<UserModel>();

        public bool Register(UserModel user)
        {
            if (!_users.Any(u => u.Email == user.Email))
            {
                _users.Add(user);
                return true;
            }
            return false;
        }
    }
}
