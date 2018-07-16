using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CashCampaignInfo Data Structure.
	/// </summary>
	[Serializable]
	public class CashCampaignInfo : AopObject
	{
		/// <summary>
		///     活动状态
		/// </summary>
		[JsonProperty("camp_status")]
		public string CampStatus { get; set; }

		/// <summary>
		///     现金红包名称
		/// </summary>
		[JsonProperty("coupon_name")]
		public string CouponName { get; set; }

		/// <summary>
		///     现金红包活动号
		/// </summary>
		[JsonProperty("crowd_no")]
		public string CrowdNo { get; set; }

		/// <summary>
		///     原始活动号,商户进行问题排查时提供
		/// </summary>
		[JsonProperty("origin_crowd_no")]
		public string OriginCrowdNo { get; set; }
	}
}