namespace LocalApi23CSharp;

using PetResource = LocalApi23CSharp.Resources.Pet;
using StoreResource = LocalApi23CSharp.Resources.Store;

public class ClientOptions
{
    public string? ApiKey { get; set; }
    public Environment Environment { get; set; } = Environment.Environment_;
    public double? Timeout { get; set; }
}

public class Client
{
    public PetResource.Client Pet { get; private set; }
    public StoreResource.Client Store { get; private set; }
    private Core.BaseClient baseClient;

    public Client()
        : this(new ClientOptions { }) { }

    public Client(ClientOptions opts)
    {
        this.baseClient = new Core.BaseClient(opts.Environment.Url, opts.Timeout);
        this.baseClient.RegisterAuth(
            "api_key",
            new Core.AuthKey(name: "api_key", location: "header", value: opts.ApiKey)
        );

        this.Pet = new PetResource.Client(this.baseClient);
        this.Store = new StoreResource.Client(this.baseClient);
    }
}
