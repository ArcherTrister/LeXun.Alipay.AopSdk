using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountBudgetQueryResponse.
	/// </summary>
	public class AlipayMarketingCampaignDiscountBudgetQueryResponse : AopResponse
	{
		/// <summary>
		///     预算ID
		/// </summary>
		[JsonProperty("budget_id")]
		public string BudgetId { get; set; }

		/// <summary>
		///     预算总金额，单位：元
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }

		/// <summary>
		///     已使用金额
		/// </summary>
		[JsonProperty("used_amount")]
		public string UsedAmount { get; set; }
	}
}