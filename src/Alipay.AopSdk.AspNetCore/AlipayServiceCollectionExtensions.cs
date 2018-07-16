﻿using System;
using Alipay.AopSdk.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Alipay.AopSdk.AspNetCore
{
	/// <summary>
	/// 支付宝 支付服务
	/// </summary>
	public static class AlipayServiceCollectionExtensions
	{
		public static IServiceCollection AddAlipay(this IServiceCollection services,Action<AlipayOptions> options)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));

			if (options == null)
				throw new ArgumentNullException(nameof(options));
			services.AddOptions();
			services.Configure(options);
            services.AddScoped<IAlipayService, AlipayService>();
			return services;
		}
	}
}