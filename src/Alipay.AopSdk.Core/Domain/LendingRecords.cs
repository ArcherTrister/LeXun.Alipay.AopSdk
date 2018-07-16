using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     LendingRecords Data Structure.
	/// </summary>
	[Serializable]
	public class LendingRecords : AopObject
	{
		/// <summary>
		///     放款时间，精确到天
		/// </summary>
		[JsonProperty("date")]
		public string Date { get; set; }

		/// <summary>
		///     放款流水描述
		/// </summary>
		[JsonProperty("remark")]
		public string Remark { get; set; }

		/// <summary>
		///     放款额度，精确到小数点2位，单位（元）
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }
	}
}