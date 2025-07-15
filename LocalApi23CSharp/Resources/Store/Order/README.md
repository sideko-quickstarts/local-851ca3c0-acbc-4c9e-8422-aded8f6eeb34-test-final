
### Delete purchase order by identifier. <a name="delete"></a>

For valid response try integer IDs with value < 1000. Anything above 1000 or non-integers will generate API errors.

**API Endpoint**: `DELETE /store/order/{orderId}`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `orderId` | ✓ | ID of the order that needs to be deleted | `123` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Store.Order;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Store.Order.Delete(new Resource.DeleteRequest { OrderId = 123 });

```

### Find purchase order by ID. <a name="get"></a>

For valid response try integer IDs with value <= 5 or > 10. Other values will generate exceptions.

**API Endpoint**: `GET /store/order/{orderId}`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `orderId` | ✓ | ID of order that needs to be fetched | `123` |

#### Example Snippet

```csharp
using Resource = LocalApi23CSharp.Resources.Store.Order;
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Store.Order.Get(new Resource.GetRequest { OrderId = 123 });

```

### Place an order for a pet. <a name="create"></a>

Place a new order in the store.

**API Endpoint**: `POST /store/order`

#### Parameters

| Parameter | Required | Description | Example |
|-----------|:--------:|-------------|--------|
| `complete` | ✗ |  | `true` |
| `id` | ✗ |  | `10` |
| `petId` | ✗ |  | `198772` |
| `quantity` | ✗ |  | `7` |
| `shipDate` | ✗ |  | `"1970-01-01T00:00:00"` |
| `status` | ✗ | Order Status | `OrderStatusEnum.Approved` |

#### Example Snippet

```csharp
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
var res = await client.Store.Order.Create();

```

#### Response

##### Type
[Order](/LocalApi23CSharp/Types/Order.cs)

##### Example
`new Order {Id = 10, PetId = 198772, Quantity = 7, Status = OrderStatusEnum.Approved}`
