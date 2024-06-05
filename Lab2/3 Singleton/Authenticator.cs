using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Singleton
{
    public class Authenticator
    {
        private static Authenticator instance;
        private static readonly object lockObject = new object();

        private Authenticator()
        {    }

        public static Authenticator Instance
        {
            get
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Authenticator();
                    }
                    return instance;
                }
            }
        }

        public void AuthenticateUser(string username, string password)
        {
            Console.WriteLine($"Аутентифікація користувача {username}...");
 
        }
    }
}
