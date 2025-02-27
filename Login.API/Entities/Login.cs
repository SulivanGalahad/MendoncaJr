﻿namespace Login.API.Entities;

public class Access
{
    public string Email { get; set; }
    public string Password { get; set; }

    public Access()
    {
        
    }

    public Access(string email, string password)
    {
        Email = email;
        Password = password;
    }
}
