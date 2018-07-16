using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     UnavailablePeriodInfo Data Structure.
	/// </summary>
	[Serializable]
	public class UnavailablePeriodInfo : AopObject
	{
		/// <summary>
		///     商品不可用时段结束日期。格式为YYYY-MM-DD，如2017-05-03
		/// </summary>
		[JsonProperty("end_day")]
		public string EndDay { get; set; }

		/// <summary>
		///     商品不可用时段开始日期。格式为YYYY-MM-DD，如2017-05-01
		/// </summary>
		[JsonProperty("start_day")]
		public string StartDay { get; set; }
	}
}