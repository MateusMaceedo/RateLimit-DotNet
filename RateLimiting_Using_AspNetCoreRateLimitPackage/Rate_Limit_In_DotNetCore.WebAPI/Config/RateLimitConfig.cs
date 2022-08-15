using AspNetCoreRateLimit;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

namespace Rate_Limit_In_DotNetCore.WebAPI.Config
{
    public static class RateLimitConfig
    {
        public static void ConfigurarRateLimit(IServiceCollection services)
        {
            services.Configure<IpRateLimitOptions>(options =>
            {
                options.EnableEndpointRateLimiting = true;
                options.StackBlockedRequests = false;
                options.HttpStatusCode = 429;
                options.RealIpHeader = "X-Real-IP";
                options.ClientIdHeader = "X-ClientId";
                options.GeneralRules = new List<RateLimitRule>
                    {
                        new RateLimitRule
                        {
                            Endpoint = "GET:/employee/getAllEmployees",
                            Period = "10s",
                            Limit = 2,
                        }
                    };

                // Client Chamador
                //options.EnableEndpointRateLimiting = true;
                //options.StackBlockedRequests = false;
                //options.HttpStatusCode = 429;
                //options.ClientIdHeader = "Client-Id";
                //options.GeneralRules = new List<RateLimitRule>
                //{
                //new RateLimitRule
                //{
                //Endpoint = "*",
                //Period = "10s",
                //Limit = 2
                //}
                //};
            });
        }
    }
}
