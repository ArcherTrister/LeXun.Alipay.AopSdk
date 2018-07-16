using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCdpRecommendQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCdpRecommendQueryModel : AopObject
	{
		/// <summary>
		///     广告标识码
		/// </summary>
		[JsonProperty("ad_code")]
		public string AdCode { get; set; }

		/// <summary>
		///     扩展信息，传json格式的字符串，包含longitude=经度；latitude=纬度；deviceId=设备标识
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     支付宝账户
		/// </summary>
		[JsonProperty("logon_id")]
		public string LogonId { get; set; }
	}
}