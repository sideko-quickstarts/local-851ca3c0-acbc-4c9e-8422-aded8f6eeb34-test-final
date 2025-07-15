
# Swagger Petstore - OpenAPI 3.0 Csharp SDK

## Overview
This is a sample Pet Store Server based on the OpenAPI 3.0 specification.  You can find out more about
Swagger at [https://swagger.io](https://swagger.io). In the third iteration of the pet store, we've switched to the design first approach!
You can now help us improve the API whether it's by making changes to the definition itself or to the code.
That way, with time, we can improve the API in general, and expose some of the new features in OAS3.

Some useful links:
- [The Pet Store repository](https://github.com/swagger-api/swagger-petstore)
- [The source API definition for the Pet Store](https://github.com/swagger-api/swagger-petstore/blob/master/src/main/resources/openapi.yaml)

#### Example Client Initialization

```csharp
using Sdk = LocalApi23CSharp;

var client = new Sdk.Client(
    new Sdk.ClientOptions { ApiKey = Environment.GetEnvironmentVariable("API_KEY")! }
);
```

## Module Documentation and Snippets

### [Pet](LocalApi23CSharp/Resources/Pet/README.md)

* [create](LocalApi23CSharp/Resources/Pet/README.md#create) - Add a new pet to the store.
* [delete](LocalApi23CSharp/Resources/Pet/README.md#delete) - Deletes a pet.
* [find_by_status](LocalApi23CSharp/Resources/Pet/README.md#find_by_status) - Finds Pets by status.
* [get](LocalApi23CSharp/Resources/Pet/README.md#get) - Find pet by ID.
* [update](LocalApi23CSharp/Resources/Pet/README.md#update) - Update an existing pet.
* [upload_image](LocalApi23CSharp/Resources/Pet/README.md#upload_image) - Uploads an image.

### [Store.Order](LocalApi23CSharp/Resources/Store/Order/README.md)

* [create](LocalApi23CSharp/Resources/Store/Order/README.md#create) - Place an order for a pet.
* [delete](LocalApi23CSharp/Resources/Store/Order/README.md#delete) - Delete purchase order by identifier.
* [get](LocalApi23CSharp/Resources/Store/Order/README.md#get) - Find purchase order by ID.

<!-- MODULE DOCS END -->
