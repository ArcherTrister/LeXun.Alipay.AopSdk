using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     YLBProfitDetailInfo Data Structure.
	/// </summary>
	[Serializable]
	public class YLBProfitDetailInfo : AopObject
	{
		/// <summary>
		///     近1日收益，单位为元
		/// </summary>
		[JsonProperty("day_profit")]
		public string DayProfit { get; set; }

		/// <summary>
		///     近1月收益，单位为元
		/// </summary>
		[JsonProperty("month_profit")]
		public string MonthProfit { get; set; }

		/// <summary>
		///     历史累计收益，单位为元
		/// </summary>
		[JsonProperty("total_profit")]
		public string TotalProfit { get; set; }

		/// <summary>
		///     近1周收益，单位为元
		/// </summary>
		[JsonProperty("week_profit")]
		public string WeekProfit { get; set; }
	}
}