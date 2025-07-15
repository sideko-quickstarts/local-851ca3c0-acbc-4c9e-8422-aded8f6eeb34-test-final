namespace LocalApi23CSharp;

public class Environment
{
    public static Environment Environment_ = new Environment("https://petstore3.swagger.io/api/v3");
    public static Environment MockServer = new Environment(
        "http://127.0.0.1:8082/v1/mock/local/local-api-23/0.1.0"
    );

    public string Url { get; private set; }

    public Environment(string url)
    {
        this.Url = url;
    }
}
