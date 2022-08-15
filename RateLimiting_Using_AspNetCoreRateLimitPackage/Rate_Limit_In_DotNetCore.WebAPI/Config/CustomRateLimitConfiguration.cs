using AspNetCoreRateLimit;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

public class CustomRateLimitConfiguration : RateLimitConfiguration
{
    public CustomRateLimitConfiguration(IOptions<IpRateLimitOptions> ipOptions,
        IOptions<ClientRateLimitOptions> clientOptions)
        : base(ipOptions, clientOptions)
    {
    }

    public override void RegisterResolvers()
    {
        ClientResolvers.Add(new QueryStringClientIdResolveContributor());
    }
}

public class QueryStringClientIdResolveContributor : IClientResolveContributor
{
    public Task<string> ResolveClientAsync(HttpContext httpContext)
    {
        return Task.FromResult<string>(httpContext.Request.Query["APIKey"]);
    }
}