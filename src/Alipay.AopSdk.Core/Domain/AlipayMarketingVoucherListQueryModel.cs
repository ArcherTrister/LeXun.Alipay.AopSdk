using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingVoucherListQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingVoucherListQueryModel : AopObject
	{
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