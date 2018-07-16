using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayAccount Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayAccount : AopObject
	{
		/// <summary>
		///     支付宝用户ID
		/// </summary>
		[JsonProperty("alipay_user_id")]
		public string AlipayUserId { get; set; }

		/// <summary>
		///     可用余额
		/// </summary>
		[JsonProperty("available_amount")]
		public string AvailableAmount { get; set; }

		/// <summary>
		///     不可用余额
		/// </summary>
		[JsonProperty("freeze_amount")]
		public string FreezeAmount { get; set; }

		/// <summary>
		///     余额总额
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }
	}
}