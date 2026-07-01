// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

Console.WriteLine("Hello, World!");


var client = new HttpClient();

var loginData = new
{
    UserName = "admin",
    Password = "123"
};


var json = JsonSerializer.Serialize(loginData);

var content = new StringContent(
    json,
    Encoding.UTF8,
    "application/json");


// LOGIN API

var response = await client.PostAsync(
    "https://localhost:5001/api/auth/login",
    content);

var tokenResponse = await response.Content.ReadAsStringAsync();

Console.WriteLine("Token Response:");
Console.WriteLine(tokenResponse);


// Extract token manually for demo

var tokenObj = JsonSerializer.Deserialize<TokenResponse>(
    tokenResponse,
    new JsonSerializerOptions
    {
        PropertyNameCaseInsensitive = true
    });


// Attach JWT Token

client.DefaultRequestHeaders.Authorization =
    new AuthenticationHeaderValue(
        "Bearer",
        tokenObj.Token);

// CALL SECURED API

var employeeResponse = await client.GetAsync(
    "https://localhost:5001/api/employee");

var employeeData =
    await employeeResponse.Content.ReadAsStringAsync();


public class TokenResponse
{
    public string Token { get; set; }
}