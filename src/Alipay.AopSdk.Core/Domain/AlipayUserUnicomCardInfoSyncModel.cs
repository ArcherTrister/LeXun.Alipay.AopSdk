using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserUnicomCardInfoSyncModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserUnicomCardInfoSyncModel : AopObject
	{
		/// <summary>
		///     状态发生变更的时间，返回自January 1, 1970, 00:00:00 GMT至手机号状态变更发生时的毫秒数, java代码获取示例：new Date().getTime()
		/// </summary>
		[JsonProperty("gmt_status_change")]
		public string GmtStatusChange { get; set; }

		/// <summary>
		///     状态发生变更的用户的联通手机号码(11位，不含国家码)
		/// </summary>
		[JsonProperty("phone_no")]
		public string PhoneNo { get; set; }

		/// <summary>
		///     联通手机号码状态（激活: CARD_ACTIVE, 注销: CARD_CLOSE）
		/// </summary>
		[JsonProperty("phone_no_status")]
		public string PhoneNoStatus { get; set; }

		/// <summary>
		///     支付宝用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}