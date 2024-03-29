using System;
using System.Collections.Generic;
using System.Linq;

namespace ATMApp;

class User
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Guid AccountId { get; set; }

    public User(string id, string name, string surname, string email, string username, string password)
    {
        Id = Guid.Parse(id);
        Name = name;
        Surname = surname;
        Email = email;
        Username = username;
        Password = password;
    }

    public static bool IsLogin(List<User> users, string username, string password, out User? user)
    {
        user = users.SingleOrDefault(p => p.Username.Equals(username) && p.Password.Equals(password));

        if (user == null)
        {
            return false;
        }

        return true;
    }
}