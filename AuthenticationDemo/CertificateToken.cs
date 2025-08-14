using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AuthenticationDemo
{
    internal class CertificateToken
    {
        public void X509Certificate2()
        { // 1. Your Azure AD Tenant ID
            string tenantId = "<TENANT_ID>";

            // 2. Your Azure AD Application (Client) ID
            string clientId = "<CLIENT_ID>";

            // 3. Your Key Vault URL
            string vaultUrl = "https://<YOUR-KEYVAULT-NAME>.vault.azure.net/";

            // 4. Load the client certificate (.pfx file)
            //    If in Azure App Service, you can load from the cert store instead
            var certificate = new X509Certificate2(
                @"C:\certs\mycert.pfx",       // path to certificate
                "your_cert_password",         // cert password
                X509KeyStorageFlags.MachineKeySet |
                X509KeyStorageFlags.EphemeralKeySet);

            // 5. Create the credential
            var credential = new ClientCertificateCredential(
                tenantId,
                clientId,
                certificate);

            // 6. Use the credential with a Key Vault client
            var secretClient = new SecretClient(new Uri(vaultUrl), credential);

            // 7. Retrieve a secret
            KeyVaultSecret secret = secretClient.GetSecret("MySecretName");
            Console.WriteLine($"Secret value: {secret.Value}");
        }
    }
}
