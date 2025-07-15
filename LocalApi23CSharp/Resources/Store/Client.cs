namespace LocalApi23CSharp.Resources.Store;

using OrderResource = LocalApi23CSharp.Resources.Store.Order;

public class Client
{
    public OrderResource.Client Order { get; private set; }

    private Core.BaseClient baseClient;

    public Client(Core.BaseClient baseClient)
    {
        this.baseClient = baseClient;

        this.Order = new OrderResource.Client(this.baseClient);
    }
}
