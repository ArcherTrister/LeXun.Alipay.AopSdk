using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineMarketingVoucherOfflineModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineMarketingVoucherOfflineModel : AopObject
	{
		/// <summary>
		///     下架描述
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     外部流水号.需商家自己生成并保证每次请求的唯一性
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     券模板编号
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}