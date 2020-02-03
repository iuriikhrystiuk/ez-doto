using IK.Dota.Api.Client.Options;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace IK.Dota.Api.Client.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDotaApiClient(this IServiceCollection serviceCollection, Action<ValveApiClientOptions> configureAptions)
        {
            serviceCollection.Configure(configureAptions);

            return serviceCollection;
        }
    }
}
