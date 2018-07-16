using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiCraftsmanDataProviderBatchqueryResponse.
	/// </summary>
	public class KoubeiCraftsmanDataProviderBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     craftsmans:手艺人信息
		/// </summary>
		[JsonProperty("craftsmans")]
		
		public List<CraftsmanOpenModel> Craftsmans { get; set; }

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
		///     门店下共手艺人数目
		/// </summary>
		[JsonProperty("total_craftsmans")]
		public long TotalCraftsmans { get; set; }

		/// <summary>
		///     总页码数目
		/// </summary>
		[JsonProperty("total_page_no")]
		public long TotalPageNo { get; set; }
	}
}