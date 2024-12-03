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

        public User(string username, string email, int userid)
        {
            this.Username = username;
            this.Email = email;
            this.Userid = userid;
        }
    }


   
}
