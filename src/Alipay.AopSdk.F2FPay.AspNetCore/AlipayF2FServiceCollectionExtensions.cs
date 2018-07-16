using Microsoft.Extensions.DependencyInjection;
using System;

namespace Alipay.AopSdk.F2FPay.AspNetCore
{
    public static class AlipayF2FServiceCollectionExtensions
    {
        public static IServiceCollection AddAlipayF2F(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));
            services.Add(ServiceDescriptor.Transient<IAlipayF2FService, AlipayF2FService>());
            return services;
        }
    }
}