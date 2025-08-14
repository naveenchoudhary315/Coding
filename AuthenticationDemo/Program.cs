// See https://aka.ms/new-console-template for more information
using Azure.Identity;

Console.WriteLine("Hello, World!");
var credential = new DefaultAzureCredential(
    new DefaultAzureCredentialOptions
    {
        ManagedIdentityClientId = "<USER_ASSIGNED_IDENTITY_CLIENT_ID>"
    });