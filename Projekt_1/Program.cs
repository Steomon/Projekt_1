using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Defines different variables
            bool usernameCorrect = false;
            bool passwordCorrect = false;
            int passwordAttempts = 3;

            Console.Write("Username: ");

            //Runs the loop until a valid username is entered
            while (!usernameCorrect)
            {
                string user = Console.ReadLine();
                if (user == "simon" || user == "Simon")
                {
                    usernameCorrect = true;
                    Console.Write("Password: ");
                    while (!passwordCorrect && passwordAttempts > 0)
                    {
                        string password = Console.ReadLine();
                        if (password == "1234")
                        {
                            passwordCorrect = true;
                            Console.WriteLine("[ACCESS GRANTED]");
                        }
                        else if (passwordAttempts > 0)
                        {
                            passwordAttempts--;
                            Console.WriteLine("Wrong password (You have " + passwordAttempts + " attempts left)");
                            if (passwordAttempts > 0)
                            {
                                Console.Write("Try again: ");
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid username.\nTry again:");
                }
            }
            Console.WriteLine("Press ENTER to exit console");
            Console.ReadLine();
        }
    }
}
