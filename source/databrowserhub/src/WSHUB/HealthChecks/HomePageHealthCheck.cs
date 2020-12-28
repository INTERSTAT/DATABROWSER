﻿using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace WSHUB.HealthChecks
{
    public class HomePageHealthCheck : IHealthCheck
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HomePageHealthCheck(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<HealthCheckResult> CheckHealthAsync(
            HealthCheckContext context,
            CancellationToken cancellationToken = default)
        {
            var request = _httpContextAccessor.HttpContext.Request;
            var myUrl = request.Scheme + "://" + request.Host;


            string pageContents;
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(myUrl);
                pageContents = await response.Content.ReadAsStringAsync();
            }

            if (pageContents.Contains(".NET Bot Black Sweatshirt", StringComparison.InvariantCultureIgnoreCase))
                return HealthCheckResult.Healthy("The check indicates a healthy result.");

            return HealthCheckResult.Unhealthy("The check indicates an unhealthy result.");
        }
    }
}