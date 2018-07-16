using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     OrderLogisticsExtInfo Data Structure.
	/// </summary>
	[Serializable]
	public class OrderLogisticsExtInfo : AopObject
	{
		/// <summary>
		///     服务结束时间，格式为yyyy-MM-dd HH:mm（到分）
		/// </summary>
		[JsonProperty("gmt_end")]
		public string GmtEnd { get; set; }

		/// <summary>
		///     服务开始时间，格式为yyyy-MM-dd HH:mm（到分）
		/// </summary>
		[JsonProperty("gmt_start")]
		public string GmtStart { get; set; }
	}
}