using RepositoryLayer;

namespace BussinessLayer
{
    public class UserRegistrationBL
    {
        UserRegistrationRL _userRegistrationRL;

        public UserRegistrationBL(UserRegistrationRL userRegistrationRL)
        {
            _userRegistrationRL = userRegistrationRL;
        }

        public string registrationBL(string username, string password)
        {
            bool isValid = _userRegistrationRL.registrationRL(username, password);
            return isValid ? "Login Successful" : "Invalid username and password";
        }
    }
}
