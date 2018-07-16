using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountWhitelistQueryResponse.
	/// </summary>
	public class AlipayMarketingCampaignDiscountWhitelistQueryResponse : AopResponse
	{
		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("camp_id")]
		public string CampId { get; set; }

		/// <summary>
		///     活动id.白名单,","隔开，最多100个
		/// </summary>
		[JsonProperty("user_white_list")]
		public string UserWhiteList { get; set; }
	}
}