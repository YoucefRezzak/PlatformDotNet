using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Model
{
    interface IDecrypt
    {
        public void decrypt();//arguments tokn
        public void uploadFile(string file);
        public Tuple<string, string> attributeKey(string file);
        public void sendFile(string fileText, string key, string username);
        public void receiveFile(string secretInfo, string key);
        public void stopThread(string filename);
    }
}
