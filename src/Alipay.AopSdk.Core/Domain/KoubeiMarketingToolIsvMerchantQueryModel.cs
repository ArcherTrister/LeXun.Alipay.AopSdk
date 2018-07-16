using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingToolIsvMerchantQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingToolIsvMerchantQueryModel : AopObject
	{
		/// <summary>
		///     页码
		/// </summary>
		[JsonProperty("page_num")]
		public string PageNum { get; set; }

		/// <summary>
		///     每页大小
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }
	}
}