namespace LocalApi23CSharpTests;

using Resource = LocalApi23CSharp.Resources.Store.Order;
using Sdk = LocalApi23CSharp;

public class StoreOrderClientTest
{
    private readonly Xunit.Abstractions.ITestOutputHelper _output;

    public StoreOrderClientTest(Xunit.Abstractions.ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public async void TestDelete200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Store.Order.Delete(new Resource.DeleteRequest { OrderId = 123 });
    }

    [Fact]
    public async void TestGet200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Store.Order.Get(new Resource.GetRequest { OrderId = 123 });
    }

    [Fact]
    public async void TestCreate200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Store.Order.Create();
    }
}
