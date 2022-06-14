using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QlyNhansu
{
    public class User
    {
        string userName;
        string password;

        public string UserName { get { return userName; } set { userName = value; } }
        public string Password { get { return password; } set { password = value; } }

        public User(string userName, string password)
        {
            this.UserName = userName;
            this.Password = password;

        }
    }
}
