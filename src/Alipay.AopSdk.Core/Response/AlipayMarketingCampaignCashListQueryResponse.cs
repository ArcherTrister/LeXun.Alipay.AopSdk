using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMarketingCampaignCashListQueryResponse.
	/// </summary>
	public class AlipayMarketingCampaignCashListQueryResponse : AopResponse
	{
		/// <summary>
		///     活动列表
		/// </summary>
		[JsonProperty("camp_list")]
		
		public List<CashCampaignInfo> CampList { get; set; }

		/// <summary>
		///     分页的页码,起始从1开始
		/// </summary>
		[JsonProperty("page_index")]
		public string PageIndex { get; set; }

		/// <summary>
		///     分页每页大小
		/// </summary>
		[JsonProperty("page_size")]
		public string PageSize { get; set; }

		/// <summary>
		///     活动总个数
		/// </summary>
		[JsonProperty("total_size")]
		public string TotalSize { get; set; }
	}
}