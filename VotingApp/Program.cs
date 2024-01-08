using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace VotingApp;

class Program
{
    static void Run(string[] args, List<User> users)
    {
        while (true)
        {
            Console.WriteLine("#Login#");
            string username = CustomFunctions.GetInputFromUser("Username");

            if (username.Equals("0") || username.Length < 3)
            {
                break;
            }
            else
            {
                string password;

                if (!users.Any(p => p.Username.Equals(username)))
                {
                    Console.WriteLine($"{username} couldn't find!\n#Sign Up#");
                    password = CustomFunctions.GetInputFromUser("Password");
                    users.Add(new User(CustomFunctions.GetInputFromUser("Username"), CustomFunctions.GetInputFromUser("Email"), password));
                }
                else
                    password = CustomFunctions.GetInputFromUser("Password");

                if (users.Any(p => p.Username.Equals(username) && p.Password.Equals(password)))
                {
                    Console.WriteLine("Login successful.");

                    if (!int.TryParse(CustomFunctions.GetInputFromUser("(1) Movie\n(2) Technology\n(3) Sport\n(0) Back\nPlease enter category number"), out int input))
                    {
                        Console.WriteLine("Value is not numeric!");
                    }
                    else if (input < 1 || input > 3)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        switch (input)
                        {
                            case 1:
                                Vote.Movie++;
                                break;
                            case 2:
                                Vote.Technology++;
                                break;
                            case 3:
                                Vote.Sport++;
                                break;
                        }

                        Vote.Total++;
                    }
                }
                else
                {
                    Console.WriteLine("Username or Password Wrong!");
                }
            }
        }

        Console.WriteLine();
        Vote.Result();
    }

    static void Main(string[] args)
    {
        try
        {
            Run(args, new List<User>
            {
                new User("Burak", "burak@email.com", "password"),
                new User("Den", "den@email.com", "password"),
                new User("Eme", "ene@email.com", "password")
            });
            if (Console.ReadLine() == "clear") Console.Clear();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
        }
    }
}