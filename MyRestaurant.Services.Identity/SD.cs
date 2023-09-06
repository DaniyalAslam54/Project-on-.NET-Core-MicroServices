using Duende.IdentityServer;
using Duende.IdentityServer.Models;

namespace MyRestaurant.Services.Identity
{
    public class SD
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile(),
            };

		public static IEnumerable<ApiScope> ApiScopes =>
			new List<ApiScope>
			{
				new ApiScope("myrestaurant","My Restaurant Server"),
				new ApiScope("read","Read the data"),
				new ApiScope("write","Write the data"),
				new ApiScope("delete","Delete the data"),
			};

		public static IEnumerable<Client> Clients =>
			new List<Client>
			{
				 new Client
				 {
					 ClientId = "client",
					 ClientSecrets = {new Secret("secret".Sha256()) },
					 AllowedGrantTypes = GrantTypes.ClientCredentials,
					 AllowedScopes = {"read","write","profile"}
				 },
				 new Client
				 {
					 ClientId = "myrestaurant",
					 ClientSecrets = {new Secret("secret".Sha256()) },
					 AllowedGrantTypes = GrantTypes.Code,
					 RedirectUris = {"https://localhost:7227/signin-oidc"},
					 PostLogoutRedirectUris = {"https://localhost:7227/signout-callback-oidc"},
					 AllowedScopes = new List<string>
					 {
						 IdentityServerConstants.StandardScopes.OpenId,
						 IdentityServerConstants.StandardScopes.Email,
						 IdentityServerConstants.StandardScopes.Profile,
						 "myrestaurant"
					 }
				 }
			};
	}
}
