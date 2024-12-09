using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingMusicApp
{
    internal class User
    {
        private string Username;
        private string Name;
        private string Email;
        private int Userid;
        private List<User> UserList;

        public User(string username, string email, int userid)
        {
            this.Username = username;
            this.Email = email;
            this.Userid = userid;
        }

        public void AddUser(User user)
        {
            UserList.Add(user);
        }

        public string GetUser(string username)
        {
            return username;
        }

        public List<User> GetUsers()
        {
            return UserList;
        }
        public List<User> GetInfo() //also include number of users
        {
            return null;
        }
    
    }


      

   
}
