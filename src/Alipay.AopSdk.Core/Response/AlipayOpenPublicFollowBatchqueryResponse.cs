using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicFollowBatchqueryResponse.
	/// </summary>
	public class AlipayOpenPublicFollowBatchqueryResponse : AopResponse
	{
		/// <summary>
		///     本次调用获取的userId个数，最大值为10000
		/// </summary>
		[JsonProperty("count")]
		public string Count { get; set; }

		/// <summary>
		///     查询分组的userid
		/// </summary>
		[JsonProperty("next_user_id")]
		public string NextUserId { get; set; }

		/// <summary>
		///     用户的userId列表
		/// </summary>
		[JsonProperty("user_id_list")]
		
		public List<string> UserIdList { get; set; }
	}
}