namespace LocalApi23CSharp.Resources.Store.Order;

public class Client
{
    private Core.BaseClient baseClient;

    public Client(Core.BaseClient baseClient)
    {
        this.baseClient = baseClient;
    }

    /// <summary>
    /// Delete purchase order by identifier.
    ///
    /// For valid response try integer IDs with value < 1000. Anything above 1000 or non-integers will generate API errors.
    ///
    /// DELETE /store/order/{orderId}
    /// </summary>
    public async Task<HttpResponseMessage> Delete(
        DeleteRequest req,
        Core.RequestOptions? reqOpts = null
    )
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Delete,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: $"/store/order/{Core.CoreUtils.JsonStringify(req.OrderId)}",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        return await builder.SendAsync();
    }

    /// <summary>
    /// Find purchase order by ID.
    ///
    /// For valid response try integer IDs with value <= 5 or > 10. Other values will generate exceptions.
    ///
    /// GET /store/order/{orderId}
    /// </summary>
    public async Task<HttpResponseMessage> Get(GetRequest req, Core.RequestOptions? reqOpts = null)
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Get,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: $"/store/order/{Core.CoreUtils.JsonStringify(req.OrderId)}",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        return await builder.SendAsync();
    }

    /// <summary>
    /// Place an order for a pet.
    ///
    /// Place a new order in the store.
    ///
    /// POST /store/order
    /// </summary>
    public async Task<Types.Order> Create(Core.RequestOptions? reqOpts = null)
    {
        return await Create(new CreateRequest(), reqOpts);
    }

    /// <summary>
    /// Place an order for a pet.
    ///
    /// Place a new order in the store.
    ///
    /// POST /store/order
    /// </summary>
    public async Task<Types.Order> Create(CreateRequest req, Core.RequestOptions? reqOpts = null)
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Post,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: "/store/order",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        builder.AddFormUrlBody(
            body: new Types.Order
            {
                Complete = req.Complete,
                Id = req.Id,
                PetId = req.PetId,
                Quantity = req.Quantity,
                ShipDate = req.ShipDate,
                Status = req.Status,
            },
            style: new Dictionary<string, string>
            {
                ["complete"] = "form",
                ["id"] = "form",
                ["petId"] = "form",
                ["quantity"] = "form",
                ["shipDate"] = "form",
                ["status"] = "form",
            },
            explode: new Dictionary<string, bool>
            {
                ["complete"] = true,
                ["id"] = true,
                ["petId"] = true,
                ["quantity"] = true,
                ["shipDate"] = true,
                ["status"] = true,
            }
        );
        return await builder.SendAsyncJsonRes<Types.Order>();
    }
}
