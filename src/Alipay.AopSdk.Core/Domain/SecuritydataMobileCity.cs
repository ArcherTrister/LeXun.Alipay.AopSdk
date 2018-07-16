using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     SecuritydataMobileCity Data Structure.
	/// </summary>
	[Serializable]
	public class SecuritydataMobileCity : AopObject
	{
		/// <summary>
		///     城市
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		///     手机号前七位
		/// </summary>
		[JsonProperty("phone_first_7_digits")]
		public string PhoneFirst7Digits { get; set; }

		/// <summary>
		///     省份
		/// </summary>
		[JsonProperty("province")]
		public string Province { get; set; }
	}
}