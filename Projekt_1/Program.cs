using System;

namespace Projekt_1
{
    class Program
    {
        static void Main(string[] args)
        {

            bool usernameCorrect = false;
            bool passwordCorrect = false;

            Console.Write("Username: ");

            while (!usernameCorrect)
            {
                string user = Console.ReadLine();
                if (user == "simon" || user == "Simon")
                {
                    usernameCorrect = true;
                    Console.Write("Password: ");
                    while (!passwordCorrect)
                    {
                        string password = Console.ReadLine();
                        if (password == "1234")
                        {
                            passwordCorrect = true;
                            Console.WriteLine("[ACCESS GRANTED]");
                        }
                        else
                        {
                            Console.Write("Wrong password, Try again: ");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong username. Try again: ");
                }
            }

            Console.WriteLine("Press ENTER to exit terminal");
            Console.ReadLine();
        }
    }
}

