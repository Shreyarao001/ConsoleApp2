using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class SignIn
    {
        public string Authenticate(string userName,string password)
        {
            string msg;
            if(string.IsNullOrEmpty(userName) || string.IsNullOrEmpty(password))
            {
                msg = "details requried";
            }
            else
            {
                if((userName=="admin") && (password =="admin@1256"))
                {
                    msg = "Authentication pass";
                }
                else
                {
                    msg = "Authentication Fail";
                
                }

            }
            return msg;
        }

    }
}
