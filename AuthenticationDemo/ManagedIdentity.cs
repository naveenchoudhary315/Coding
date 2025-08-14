using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationDemo
{
    internal class ManagedIdentity
    {
        public void GetManagedIdentity()
        {
            // Your Key Vault URI
            string keyVaultUri = "https://<your-keyvault-name>.vault.azure.net/";

            // Create a credential that uses Managed Identity
            var credential = new DefaultAzureCredential();

            // Use the credential to connect to Key Vault
            var client = new SecretClient(new Uri(keyVaultUri), credential);

            // Read a secret
            KeyVaultSecret secret = client.GetSecret("MySecretName");

            Console.WriteLine($"Secret Value: {secret.Value}");
        }
    }
}
