namespace LocalApi23CSharp.Resources.Pet;

public class Client
{
    private Core.BaseClient baseClient;

    public Client(Core.BaseClient baseClient)
    {
        this.baseClient = baseClient;
    }

    /// <summary>
    /// Deletes a pet.
    ///
    /// Delete a pet.
    ///
    /// DELETE /pet/{petId}
    /// </summary>
    public async Task<HttpResponseMessage> Delete(
        DeleteRequest req,
        Core.RequestOptions? reqOpts = null
    )
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Delete,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: $"/pet/{Core.CoreUtils.JsonStringify(req.PetId)}",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        return await builder.SendAsync();
    }

    /// <summary>
    /// Finds Pets by status.
    ///
    /// Multiple status values can be provided with comma separated strings.
    ///
    /// GET /pet/findByStatus
    /// </summary>
    public async Task<HttpResponseMessage> FindByStatus(Core.RequestOptions? reqOpts = null)
    {
        return await FindByStatus(new FindByStatusRequest(), reqOpts);
    }

    /// <summary>
    /// Finds Pets by status.
    ///
    /// Multiple status values can be provided with comma separated strings.
    ///
    /// GET /pet/findByStatus
    /// </summary>
    public async Task<HttpResponseMessage> FindByStatus(
        FindByStatusRequest req,
        Core.RequestOptions? reqOpts = null
    )
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Get,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: "/pet/findByStatus",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        builder.AddQuery(name: "status", value: req.Status, style: "form", explode: true);
        return await builder.SendAsync();
    }

    /// <summary>
    /// Find pet by ID.
    ///
    /// Returns a single pet.
    ///
    /// GET /pet/{petId}
    /// </summary>
    public async Task<HttpResponseMessage> Get(GetRequest req, Core.RequestOptions? reqOpts = null)
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Get,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: $"/pet/{Core.CoreUtils.JsonStringify(req.PetId)}",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        return await builder.SendAsync();
    }

    /// <summary>
    /// Add a new pet to the store.
    ///
    /// Add a new pet to the store.
    ///
    /// POST /pet
    /// </summary>
    public async Task<HttpResponseMessage> Create(
        CreateRequest req,
        Core.RequestOptions? reqOpts = null
    )
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Post,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: "/pet",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        builder.AddJsonBody(
            new Types.Pet
            {
                Category = req.Category,
                Id = req.Id,
                Status = req.Status,
                Tags = req.Tags,
                Name = req.Name,
                PhotoUrls = req.PhotoUrls,
            },
            "application/json"
        );
        return await builder.SendAsync();
    }

    /// <summary>
    /// Uploads an image.
    ///
    /// Upload image of the pet.
    ///
    /// POST /pet/{petId}/uploadImage
    /// </summary>
    public async Task<Types.ApiResponse> UploadImage(
        UploadImageRequest req,
        Core.RequestOptions? reqOpts = null
    )
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Post,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: $"/pet/{Core.CoreUtils.JsonStringify(req.PetId)}/uploadImage",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        builder.AddQuery(
            name: "additionalMetadata",
            value: req.AdditionalMetadata,
            style: "form",
            explode: true
        );
        builder.AddBinaryBody(req.Data);
        return await builder.SendAsyncJsonRes<Types.ApiResponse>();
    }

    /// <summary>
    /// Update an existing pet.
    ///
    /// Update an existing pet by Id.
    ///
    /// PUT /pet
    /// </summary>
    public async Task<HttpResponseMessage> Update(
        UpdateRequest req,
        Core.RequestOptions? reqOpts = null
    )
    {
        var builder = new Core.RequestBuilder(
            method: HttpMethod.Put,
            baseUrl: this.baseClient.GetBaseUrl(),
            path: "/pet",
            timeout: this.baseClient.Timeout,
            opts: reqOpts
        );
        await builder.AddAuths(this.baseClient.GetAuths(new[] { "api_key" }));
        builder.AddJsonBody(
            new Types.Pet
            {
                Category = req.Category,
                Id = req.Id,
                Status = req.Status,
                Tags = req.Tags,
                Name = req.Name,
                PhotoUrls = req.PhotoUrls,
            },
            "application/json"
        );
        return await builder.SendAsync();
    }
}
