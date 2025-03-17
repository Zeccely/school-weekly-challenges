using DAL;

namespace BLL
{
    public class UserService
    {
        private UserDB _userDB;

        public UserService() 
        { 
            _userDB = new UserDB();
        }

        public string GetUserName()
        {
            return _userDB.GetUserName();
        }
    }
}
