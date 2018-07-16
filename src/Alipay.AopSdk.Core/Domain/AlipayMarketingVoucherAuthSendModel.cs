using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingVoucherAuthSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingVoucherAuthSendModel : AopObject
	{
		/// <summary>
		///     外部业务订单号，用于幂等控制
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     经过用户授权过后的发券码
		/// </summary>
		[JsonProperty("send_code")]
		public string SendCode { get; set; }

		/// <summary>
		///     券模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }

		/// <summary>
		///     支付宝用户ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}