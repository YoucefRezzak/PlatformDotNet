using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    class Authentification : IAuthentification
    {
        private string username;
        private string password;
        private string tokenApp;
        private string tokenUser;
        private bool valid;
        public bool checkCredential()
        {
            throw new NotImplementedException();
        }

        public bool checkToken()
        {
            throw new NotImplementedException();
        }

        public string GenerateTokenUser()
        {
            throw new NotImplementedException();
        }

        public void sendToken()
        {
            throw new NotImplementedException();
        }

        public Tuple<bool, string> userLogin()
        {
            throw new NotImplementedException();
        }
    }
}
