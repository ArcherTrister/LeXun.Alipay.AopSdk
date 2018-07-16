using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     ZhimaCreditWatchlistiiGetResponse.
	/// </summary>
	public class ZhimaCreditWatchlistiiGetResponse : AopResponse
	{
		/// <summary>
		///     芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
		/// </summary>
		[JsonProperty("biz_no")]
		public string BizNo { get; set; }

		/// <summary>
		///     所查询的某个用户的行业关注名单列表。当is_matched为true时会返回该参数。
		/// </summary>
		[JsonProperty("details")]
		
		public List<ZmWatchListDetail> Details { get; set; }

		/// <summary>
		///     true=命中 在关注名单中  false=未命中
		/// </summary>
		[JsonProperty("is_matched")]
		public bool IsMatched { get; set; }
	}
}