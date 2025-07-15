namespace LocalApi23CSharpTests;

using System.Text;
using Resource = LocalApi23CSharp.Resources.Pet;
using Sdk = LocalApi23CSharp;

public class PetClientTest
{
    private readonly Xunit.Abstractions.ITestOutputHelper _output;

    public PetClientTest(Xunit.Abstractions.ITestOutputHelper output)
    {
        _output = output;
    }

    [Fact]
    public async void TestDelete200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.Delete(new Resource.DeleteRequest { PetId = 123 });
    }

    [Fact]
    public async void TestFindByStatus200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.FindByStatus();
    }

    [Fact]
    public async void TestFindByStatus200SuccessRequiredOnly()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.FindByStatus();
    }

    [Fact]
    public async void TestGet200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.Get(new Resource.GetRequest { PetId = 123 });
    }

    [Fact]
    public async void TestCreate200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.Create(
            new Resource.CreateRequest
            {
                Category = new Sdk.Types.Category { Id = 1, Name = "Dogs" },
                Id = 10,
                Name = "doggie",
                PhotoUrls = new List<string> { "string" },
                Status = Sdk.Types.PetStatusEnum.Available,
                Tags = new List<Sdk.Types.Tag>
                {
                    new Sdk.Types.Tag { Id = 123, Name = "string" },
                },
            }
        );
    }

    [Fact]
    public async void TestUploadImage200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.UploadImage(
            new Resource.UploadImageRequest
            {
                Data = new Sdk.Core.UploadFile(
                    "test.txt",
                    "text/plain",
                    Encoding.UTF8.GetBytes("Hello World!")
                ),
                PetId = 123,
                AdditionalMetadata = "string",
            }
        );
    }

    [Fact]
    public async void TestUploadImage200SuccessRequiredOnly()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.UploadImage(
            new Resource.UploadImageRequest
            {
                Data = new Sdk.Core.UploadFile(
                    "test.txt",
                    "text/plain",
                    Encoding.UTF8.GetBytes("Hello World!")
                ),
                PetId = 123,
            }
        );
    }

    [Fact]
    public async void TestUpdate200SuccessAllParams()
    {
        var client = new Sdk.Client(
            new Sdk.ClientOptions { ApiKey = "API_KEY", Environment = Sdk.Environment.MockServer }
        );
        _ = await client.Pet.Update(
            new Resource.UpdateRequest
            {
                Category = new Sdk.Types.Category { Id = 1, Name = "Dogs" },
                Id = 10,
                Name = "doggie",
                PhotoUrls = new List<string> { "string" },
                Status = Sdk.Types.PetStatusEnum.Available,
                Tags = new List<Sdk.Types.Tag>
                {
                    new Sdk.Types.Tag { Id = 123, Name = "string" },
                },
            }
        );
    }
}
