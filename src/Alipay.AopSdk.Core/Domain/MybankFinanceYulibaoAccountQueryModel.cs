using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MybankFinanceYulibaoAccountQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class MybankFinanceYulibaoAccountQueryModel : AopObject
	{
		/// <summary>
		///     基金代码，必填。目前默认填001529，代表余利宝
		/// </summary>
		[JsonProperty("fund_code")]
		public string FundCode { get; set; }
	}
}