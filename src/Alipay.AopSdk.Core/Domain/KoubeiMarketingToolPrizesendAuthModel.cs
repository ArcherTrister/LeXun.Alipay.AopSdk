using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingToolPrizesendAuthModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingToolPrizesendAuthModel : AopObject
	{
		/// <summary>
		///     奖品ID
		/// </summary>
		[JsonProperty("prize_id")]
		public string PrizeId { get; set; }

		/// <summary>
		///     外部流水号，保证业务幂等性
		/// </summary>
		[JsonProperty("req_id")]
		public string ReqId { get; set; }

		/// <summary>
		///     发奖用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}