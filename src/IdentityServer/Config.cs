using Duende.IdentityServer.Models;

namespace IdentityServer;

public static class Config
{
    public static IEnumerable<IdentityResource> IdentityResources =>
        new IdentityResource[]
        { 
            new IdentityResources.OpenId()
        };

    public static IEnumerable<ApiScope> ApiScopes =>
        new List<ApiScope>
            {
            new ApiScope(name:"api1",displayName:"MyApi")
        };

    public static IEnumerable<Client> Clients =>
        new Client[] 
            { };
}