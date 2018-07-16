using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingVoucherTemplatelistQueryResponse.
	/// </summary>
	public class AlipayMarketingVoucherTemplatelistQueryResponse : AopResponse
	{
		/// <summary>
		///     当前页码,页码从1开始
		/// </summary>
		[JsonProperty("current_page")]
		public long CurrentPage { get; set; }

		/// <summary>
		///     每页条数
		/// </summary>
		[JsonProperty("items_per_page")]
		public long ItemsPerPage { get; set; }

		/// <summary>
		///     总条数
		/// </summary>
		[JsonProperty("total_items")]
		public long TotalItems { get; set; }

		/// <summary>
		///     总页数
		/// </summary>
		[JsonProperty("total_pages")]
		public long TotalPages { get; set; }

		/// <summary>
		///     券模板列表
		/// </summary>
		[JsonProperty("voucher_templates")]
		
		public List<VoucherTemplateLiteInfo> VoucherTemplates { get; set; }
	}
}