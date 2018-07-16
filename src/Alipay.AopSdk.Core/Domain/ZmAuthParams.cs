using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZmAuthParams Data Structure.
	/// </summary>
	[Serializable]
	public class ZmAuthParams : AopObject
	{
		/// <summary>
		///     商户在芝麻端申请的appId
		/// </summary>
		[JsonProperty("buckle_app_id")]
		public string BuckleAppId { get; set; }

		/// <summary>
		///     商户在芝麻端申请的merchantId
		/// </summary>
		[JsonProperty("buckle_merchant_id")]
		public string BuckleMerchantId { get; set; }
	}
}