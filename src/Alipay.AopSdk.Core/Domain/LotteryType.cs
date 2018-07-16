using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     LotteryType Data Structure.
	/// </summary>
	[Serializable]
	public class LotteryType : AopObject
	{
		/// <summary>
		///     彩种ID
		/// </summary>
		[JsonProperty("lottery_type_id")]
		public long LotteryTypeId { get; set; }

		/// <summary>
		///     彩种名称
		/// </summary>
		[JsonProperty("lottery_type_name")]
		public string LotteryTypeName { get; set; }
	}
}