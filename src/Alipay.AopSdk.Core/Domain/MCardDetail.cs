using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MCardDetail Data Structure.
	/// </summary>
	[Serializable]
	public class MCardDetail : AopObject
	{
		/// <summary>
		///     储值卡可用余额
		/// </summary>
		[JsonProperty("available_amount")]
		public string AvailableAmount { get; set; }

		/// <summary>
		///     储值卡名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     储值卡支付金额
		/// </summary>
		[JsonProperty("pay_amount")]
		public string PayAmount { get; set; }
	}
}