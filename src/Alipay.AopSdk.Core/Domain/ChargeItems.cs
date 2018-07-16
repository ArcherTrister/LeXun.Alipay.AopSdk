using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ChargeItems Data Structure.
	/// </summary>
	[Serializable]
	public class ChargeItems : AopObject
	{
		/// <summary>
		///     缴费项名称
		/// </summary>
		[JsonProperty("item_name")]
		public string ItemName { get; set; }

		/// <summary>
		///     缴费项金额
		/// </summary>
		[JsonProperty("item_price")]
		public string ItemPrice { get; set; }
	}
}