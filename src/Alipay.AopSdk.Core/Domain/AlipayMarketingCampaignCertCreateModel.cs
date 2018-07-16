using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCampaignCertCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCampaignCertCreateModel : AopObject
	{
		/// <summary>
		///     凭证批次名称
		/// </summary>
		[JsonProperty("cert_name")]
		public string CertName { get; set; }

		/// <summary>
		///     拓展信息
		/// </summary>
		[JsonProperty("extend_info")]
		public string ExtendInfo { get; set; }

		/// <summary>
		///     备注
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     凭证有效次数，数值(最大为10000)
		/// </summary>
		[JsonProperty("valid_count")]
		public string ValidCount { get; set; }
	}
}