using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace Personal_Information;

public class AcccessInformation
{
    private ICollection<Credential> _credentials;

    public AcccessInformation()
    {
        _credentials = new HashSet<Credential>();
    }
    public ICollection<Credential> Credentials => _credentials;

    public void AddCredential(Credential credential)
    {
        _credentials.Add(credential);
    }

    public Credential GetSingleCredential(string domain)
        => (Credential)_credentials.Where(c => c.Domain == domain);

    public void UpdateDomain(string domain)
    {
        var credential = this.GetSingleCredential(domain);
        credential.Domain = domain;
    }

    public void UpdateUsername(string username)
    {
        var credential = this.GetSingleCredential(username);
        credential.Username = username;
    }

    public void UpdatePassword(string password)
    {
        var credential = this.GetSingleCredential(password);
        credential.Password = password;
    }

    public void DeleteCredential(Credential credential)
    => _credentials.Remove(credential);

}

