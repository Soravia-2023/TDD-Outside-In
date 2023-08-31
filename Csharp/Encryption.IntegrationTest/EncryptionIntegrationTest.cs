using Microsoft.AspNetCore.Mvc.Testing;
using System.Net;
using System.Net.Http.Json;

namespace Encryption.IntegrationTest;
public class EncryptionIntegrationTests
{
    private WebApplicationFactory<Program> sut;
    private HttpClient client;

    public WebApplicationFactory<Program> Sut { get => sut; set => sut = value; }

    [SetUp]
    public void StartServer()
    {
        sut = new WebApplicationFactory<Program>();
        client = sut.CreateClient();
    }

    [TearDown]
    public void TearDown() => this.sut.Dispose();

    public async Task TestSomething()
    {
        Console.WriteLine("something");
    }
}
