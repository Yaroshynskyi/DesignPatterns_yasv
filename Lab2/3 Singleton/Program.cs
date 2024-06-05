using System;
using _3_Singleton;

class Program
{
    static void Main(string[] args)
    {
       
        Authenticator auth1 = Authenticator.Instance;
        Authenticator auth2 = Authenticator.Instance;

     // Перевірка, що auth1 та auth2 вказують на один і той же об'єкт Authenticator:
        Console.WriteLine($"auth1 == auth2: {auth1 == auth2}"); 

 
        auth1.AuthenticateUser("user123", "password123");
    }
}   