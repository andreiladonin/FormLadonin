﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form
{
    
    class LoginAndPasw

    {
        public string Login;
        public string Pasword;
        private int LockOut = 3;


        public LoginAndPasw(string login, string pasword )
        {
            Login = login;
            Pasword = pasword;
        }

        public void SaveFile()
        {
            File.WriteAllText("Log.txt", Login);

            File.WriteAllText("Psw.txt", Pasword);

            File.WriteAllText("LockOut.txt", Convert.ToString(LockOut));
        }
    }
}
