using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayUserTradeSearchResponse.
	/// </summary>
	public class AlipayUserTradeSearchResponse : AopResponse
	{
		/// <summary>
		///     总页数
		/// </summary>
		[JsonProperty("total_pages")]
		public string TotalPages { get; set; }

		/// <summary>
		///     总记录数
		/// </summary>
		[JsonProperty("total_results")]
		public string TotalResults { get; set; }

		/// <summary>
		///     交易记录列表
		/// </summary>
		[JsonProperty("trade_records")]
		
		public List<TradeRecord> TradeRecords { get; set; }
	}
}