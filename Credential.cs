using Microsoft.VisualBasic.ApplicationServices;

namespace Personal_Information;

public class Credential
{
    public Credential(string domain, string username, string password)
    {
        Domain = domain;
        Username = username;
        Password = password;
        
    }
    public string Domain { get; set; }

    public string Username { get; set; }

    public string Password { get; set; }

    public override string ToString()
    {
        return $"{Domain}: Username: {Username} Password: {Password}";
    }
}