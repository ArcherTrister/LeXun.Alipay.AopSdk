using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicLabelUserDeleteModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicLabelUserDeleteModel : AopObject
	{
		/// <summary>
		///     标签id
		/// </summary>
		[JsonProperty("label_id")]
		public string LabelId { get; set; }

		/// <summary>
		///     支付宝用户的userid，2088开头长度为16位的字符串
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}