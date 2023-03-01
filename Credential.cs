using Microsoft.VisualBasic.ApplicationServices;

namespace Personal_Information;

public class Credential
{
    private string _domain;
    private string _username;
    private string _password;
    
    public Credential(string domain, string username, string password)
    {
        _domain = domain;
        _username = username;
        _password = password;
        
    }
    public string Domain
    {
        get => _domain;
        set => _domain = value;
    }
    public string Username 
    {
        get => _username;
        set => _username = value;
    }

    public string Password
    {
        get => _password; 
        set => _password = value;
    }

    public override string ToString()
    {
        return $"{Domain}: Username: {Username} Password: {Password}";
    }
}