namespace Blog.Api.Infrastructure;

public static class ConfigKestrelExtension
{
    public static WebApplicationBuilder ConfigKestrel(this WebApplicationBuilder builder)
    {
        builder.WebHost.ConfigureKestrel(options =>
        {
            options.Listen(IPAddress.Any, 80, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http1AndHttp2;
            });
            options.Listen(IPAddress.Any, 81, listenOptions =>
            {
                listenOptions.Protocols = HttpProtocols.Http2;
            });
        });

        return builder;
    }
}