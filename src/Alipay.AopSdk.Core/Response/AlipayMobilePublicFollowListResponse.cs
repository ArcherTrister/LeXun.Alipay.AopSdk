using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobilePublicFollowListResponse.
	/// </summary>
	public class AlipayMobilePublicFollowListResponse : AopResponse
	{
		/// <summary>
		///     返回结果码，如200，标识成功
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     当前组的值
		/// </summary>
		[JsonProperty("count")]
		public string Count { get; set; }

		/// <summary>
		///     用户数据
		/// </summary>
		[JsonProperty("data")]
		public Data Data { get; set; }

		/// <summary>
		///     与nextUserId对应，标准Alipay UserId
		/// </summary>
		[JsonProperty("next_alipay_user_id")]
		public string NextAlipayUserId { get; set; }

		/// <summary>
		///     查询分组的userid
		/// </summary>
		[JsonProperty("next_user_id")]
		public string NextUserId { get; set; }
	}
}