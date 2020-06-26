using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    interface IAuthentification
    {
        public Tuple<bool, string> userLogin();
        public bool checkToken();
        public bool checkCredential();
        public string GenerateTokenUser();
        public void sendToken();
    }
}
