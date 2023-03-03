using Microsoft.VisualBasic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace Personal_Information;

public class AccessInformation
{
    private readonly ICollection<Credential> _credentials;

    public AccessInformation()
    {
        _credentials = new HashSet<Credential>();
    }
    public ICollection<Credential> Credentials => _credentials;

    public void AddCredential(Credential credential)
    =>_credentials.Add(credential);

    public void UpdateDomain(Credential credential, string domain)
    => credential!.Domain = domain;

    public void UpdateUsername(Credential credential, string username)
    => credential.Username = username;

    public void UpdatePassword(Credential credential, string password) => credential.Password = password;

    public void DeleteCredential(Credential credential)
    => _credentials.Remove(credential);
    
    public ICollection<Credential> GetCredentialsByDomain(string domain)
        => (ICollection<Credential>)_credentials.Where(c => c.Domain == domain);
}

