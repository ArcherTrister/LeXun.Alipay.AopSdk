using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     OpenItem Data Structure.
	/// </summary>
	[Serializable]
	public class OpenItem : AopObject
	{
		/// <summary>
		///     单品编号
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; }

		/// <summary>
		///     单品检测状态  0，未检测  1，未通过  2，已通过
		/// </summary>
		[JsonProperty("item_status")]
		public string ItemStatus { get; set; }

		/// <summary>
		///     门店id
		/// </summary>
		[JsonProperty("store_id")]
		public string StoreId { get; set; }
	}
}