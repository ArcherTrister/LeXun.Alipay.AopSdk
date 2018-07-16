using System.Collections.Generic;
using Alipay.AopSdk.Core;

namespace Alipay.AopSdk.AspNetCore
{
	public interface IAlipayService:IAopClient
	{
		AlipayOptions Options { get; set; }

		bool RSACheckV1(Dictionary<string, string> data);
/*
		Dictionary<string, string> RequestParamToDictionaryForHttpPost();

		Dictionary<string, string> RequestParamToDictionaryForHttpGet();*/
	}
}