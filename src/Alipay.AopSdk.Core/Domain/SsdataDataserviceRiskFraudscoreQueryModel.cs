using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SsdataDataserviceRiskFraudscoreQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class SsdataDataserviceRiskFraudscoreQueryModel : AopObject
	{
		/// <summary>
		///     商户和支付宝交互时，用于代表支付宝分配给商户ID
		/// </summary>
		[JsonProperty("partner_id")]
		public string PartnerId { get; set; }

		/// <summary>
		///     版本号
		/// </summary>
		[JsonProperty("sys_version")]
		public string SysVersion { get; set; }

		/// <summary>
		///     蚂蚁统一会员ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}