using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOfflineMarketApplyorderBatchqueryResponse.
	/// </summary>
	public class AlipayOfflineMarketApplyorderBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     支付宝操作流水信息列表
		/// </summary>
		[JsonProperty("biz_order_infos")]
		
		public List<BizOrderQueryResponse> BizOrderInfos { get; set; }

		/// <summary>
		///     当前页码
		/// </summary>
		[JsonProperty("current_page_no")]
		public long CurrentPageNo { get; set; }

		/// <summary>
		///     每页记录数
		/// </summary>
		[JsonProperty("page_size")]
		public long PageSize { get; set; }

		/// <summary>
		///     总记录数
		/// </summary>
		[JsonProperty("total_items")]
		public long TotalItems { get; set; }

		/// <summary>
		///     总页码数目
		/// </summary>
		[JsonProperty("total_page_no")]
		public long TotalPageNo { get; set; }
	}
}