
### Deletes a pet. <a name="delete"></a>

Delete a pet.

**API Endpoint**: `DELETE /pet/{petId}`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `petId` | ✓ | Pet id to delete | `123` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Pet;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Pet.Delete(new Resource.DeleteRequest { PetId = 123 });

```

### Finds Pets by status. <a name="find_by_status"></a>

Multiple status values can be provided with comma separated strings.

**API Endpoint**: `GET /pet/findByStatus`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `status` | ✗ | Status values that need to be considered for filter | `PetFindByStatusStatusEnum.Available` |

#### Example Snippet

```csharp
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Pet.FindByStatus();

```

### Find pet by ID. <a name="get"></a>

Returns a single pet.

**API Endpoint**: `GET /pet/{petId}`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `petId` | ✓ | ID of pet to return | `123` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Pet;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Pet.Get(new Resource.GetRequest { PetId = 123 });

```

### Add a new pet to the store. <a name="create"></a>

Add a new pet to the store.

**API Endpoint**: `POST /pet`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `name` | ✓ |  | `"doggie"` |
| `photoUrls` | ✓ |  | `new List<string> {"string"}` |
| `category` | ✗ |  | `new Category {Id = 1, Name = "Dogs"}` |
| `id` | ✗ |  | `10` |
| `status` | ✗ | pet status in the store | `PetStatusEnum.Available` |
| `tags` | ✗ |  | `new List<Tag> {new Tag {}}` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Pet;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Pet.Create(
    new Resource.CreateRequest
    {
        Id = 10,
        Name = "doggie",
        PhotoUrls = new List<string> { "string" },
    }
);

```

### Uploads an image. <a name="upload_image"></a>

Upload image of the pet.

**API Endpoint**: `POST /pet/{petId}/uploadImage`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `data` | ✓ |  | `Core.UploadFile("uploads/file.pdf")` |
| `petId` | ✓ | ID of pet to update | `123` |
| `additionalMetadata` | ✗ | Additional Metadata | `"string"` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Pet;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Pet.UploadImage(
    new Resource.UploadImageRequest { Data = Sdk.Core.UploadFile("uploads/file.pdf"), PetId = 123 }
);

```

#### Response

##### Type
[ApiResponse](/LocalApi23CSharp/Types/ApiResponse.cs)

##### Example
`new ApiResponse {}`

### Update an existing pet. <a name="update"></a>

Update an existing pet by Id.

**API Endpoint**: `PUT /pet`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `name` | ✓ |  | `"doggie"` |
| `photoUrls` | ✓ |  | `new List<string> {"string"}` |
| `category` | ✗ |  | `new Category {Id = 1, Name = "Dogs"}` |
| `id` | ✗ |  | `10` |
| `status` | ✗ | pet status in the store | `PetStatusEnum.Available` |
| `tags` | ✗ |  | `new List<Tag> {new Tag {}}` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Pet;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Pet.Update(
    new Resource.UpdateRequest
    {
        Id = 10,
        Name = "doggie",
        PhotoUrls = new List<string> { "string" },
    }
);

```
