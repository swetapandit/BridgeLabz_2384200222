using RepositoryLayer;
using Models;
using System.Security.Cryptography;
using System.Text;

namespace BusinessLayer
{
    public class UserRegistrationBL
    {
        private readonly UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public UserResponseModel RegisterUser(UserRegistrationDTO userDto)
        {
            UserModel newUser = new UserModel
            {
                FirstName = userDto.FirstName,
                LastName = userDto.LastName,
                Email = userDto.Email,
                PasswordHash = HashPassword(userDto.Password) // Store hashed password
            };

            bool isRegistered = _userRegistrationRL.Register(newUser);

            return new UserResponseModel
            {
                Message = isRegistered ? "Registration Successful" : "User Already Exists",
                Success = isRegistered
            };
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(bytes);
            }
        }
    }
}
