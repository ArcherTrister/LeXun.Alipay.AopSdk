using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDrawcampStatusUpdateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDrawcampStatusUpdateModel : AopObject
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     修改的活动状态，CAMP_PAUSED  暂停状态, CAMP_ENDED  结束状态, CAMP_GOING启动状态，只支持以上3种状态变更。结束状态的活动不允许在修改活动状态。
		/// </summary>
		[JsonProperty("camp_status")]
		public string CampStatus { get; set; }
	}
}