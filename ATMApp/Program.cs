using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace ATMApp;

class Program
{
    static void Run(string[] args, string message, List<User> users, List<Account> accounts)
    {
        string username = CustomFunctions.GetInputFromUser("Username");
        string password = CustomFunctions.GetInputFromUser("Password");

        if (User.IsLogin(users, username, password, out User? user))
        {
            Logger.FileLogMessage($"Log in successfull. Username: {username}.");

            Account? account = accounts.SingleOrDefault(p => p.UserId.Equals(user.Id));

            while (true)
            {
                if (!int.TryParse(CustomFunctions.GetInputFromUser(message), out int input))
                {
                    Console.WriteLine("Value is not numeric!");
                }
                else if (input < 1 || input > 3)
                {
                    Console.WriteLine($"Error: value must be greater than zero and less than four! input: {input}");
                    Logger.FileLogMessage($"Log out successfull. Username: {username}.");
                    break;
                }
                else
                {
                    Transaction transaction = (Transaction)input;

                    if (double.TryParse(CustomFunctions.GetInputFromUser("Amount"), out double amount))
                    {
                        switch (transaction)
                        {
                            case Transaction.Withdraw:
                                account.Withdraw(amount);
                                Logger.FileLogSuccessTransaction(Transaction.Withdraw, amount);
                                break;
                            case Transaction.Deposit:
                                account.Deposit(amount);
                                Logger.FileLogSuccessTransaction(Transaction.Deposit, amount);
                                break;
                            case Transaction.Pay:
                                account.Pay(amount);
                                Logger.FileLogSuccessTransaction(Transaction.Pay, amount);
                                break;
                        }
                    }
                    else
                    {
                        string log = "Amount is invalid!";
                        Console.WriteLine(log);
                        Logger.FileLogFailureTransaction(log, transaction);
                    }
                }
            }
        }
        else
        {
            string log = $"Username or Password is wrong! Username: {username} Password: {password}.";
            Console.WriteLine(log);
            Logger.FileLogMessage(log);
        }
    }

    static void Main(string[] args)
    {
        try
        {
            Run(args,
            "(1) Withdraw\n(2) Deposit\n(3) Pay\n(0) Quit\nPlease enter number of transaction",
            new List<User>
            {
                new User("11d9f7d7-caf1-47ec-a104-83dfc487c06d", "Burak", "Turhan", "burak@email.com", "brktrhn", "password"),
                new User("32b46e7e-99f7-4b5c-89d9-0d462b4be5fd", "Emir", "Timur", "timur@email.com", "emrtmr", "password"),
                new User("dd479e55-49d6-4e74-a26f-7a9fe796f9ed", "Alexander", "Great", "alexander@email.com", "alexgrt", "password")
            },
            new List<Account>
            {
                new Account("11d9f7d7-caf1-47ec-a104-83dfc487c06d", 1000000),
                new Account("32b46e7e-99f7-4b5c-89d9-0d462b4be5fd", 1000000),
                new Account("dd479e55-49d6-4e74-a26f-7a9fe796f9ed", 1000000)
            });
            if (Console.ReadLine() == "clear") Console.Clear();
        }
        catch (Exception exp)
        {
            Console.WriteLine(exp);
        }
    }
}