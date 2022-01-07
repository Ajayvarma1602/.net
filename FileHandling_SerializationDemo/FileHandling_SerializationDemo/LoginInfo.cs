using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling_SerializationDemo
{
    class LoginInfo
    {
        string userName;
            
        string passWord;

        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }

        public string Password
        {
            get { return passWord; }
            set { passWord = value; }
        }
    }
}
