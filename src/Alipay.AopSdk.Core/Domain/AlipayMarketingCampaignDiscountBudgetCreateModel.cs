using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignDiscountBudgetCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignDiscountBudgetCreateModel : AopObject
	{
		/// <summary>
		///     业务名称，和out_biz_no一起进行幂等控制
		/// </summary>
		[JsonProperty("biz_from")]
		public string BizFrom { get; set; }

		/// <summary>
		///     预算库使用结束时间，格式：yyyy-MM-dd mm:hh:ss
		/// </summary>
		[JsonProperty("gmt_end")]
		public string GmtEnd { get; set; }

		/// <summary>
		///     预算名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     预算创建业务号，和biz_from一起进行幂等控制
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     积分预算库ID
		/// </summary>
		[JsonProperty("out_budget_no")]
		public string OutBudgetNo { get; set; }

		/// <summary>
		///     发行人支付宝登录账号
		/// </summary>
		[JsonProperty("publisher_logon_id")]
		public string PublisherLogonId { get; set; }

		/// <summary>
		///     预算金额，单位：元
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }
	}
}