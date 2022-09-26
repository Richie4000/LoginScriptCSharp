using System.Runtime.CompilerServices;
using System.Security.AccessControl;

class LoginScript
{
    public static void Main(String[] args)
    
    {
        int Attempts = 0;
        for (int i = 0; i < 3; i++)
        {
            string RealPassword = "Password!";

            Console.WriteLine("Enter username");
            string? getUsername = Console.ReadLine();

            Console.WriteLine("Your username is " + getUsername);

            Console.WriteLine("Enter password");

            string? getPassword = Console.ReadLine();
       
            if (getPassword != RealPassword)
                Attempts++;
            else
                break;

        }

        if (Attempts > 2)
            Console.WriteLine("Unfortunately, your account has been blocked");
        else
            Console.WriteLine("Thank you for logging in successfully");
    }


}
