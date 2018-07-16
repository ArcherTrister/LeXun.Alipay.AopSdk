using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineMarketingVoucherModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineMarketingVoucherModifyModel : AopObject
	{
		/// <summary>
		///     预算信息
		/// </summary>
		[JsonProperty("budget_info")]
		public BudgetInfo BudgetInfo { get; set; }

		/// <summary>
		///     扩展参数
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     发放次数限制
		/// </summary>
		[JsonProperty("get_count_limit")]
		public PeriodInfo GetCountLimit { get; set; }

		/// <summary>
		///     外部流水号.需商家自己生成并保证每次请求的唯一性
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     券信息
		/// </summary>
		[JsonProperty("voucher_info")]
		public VoucherModifyInfo VoucherInfo { get; set; }
	}
}