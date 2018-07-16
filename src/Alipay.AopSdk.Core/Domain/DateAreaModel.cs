using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     DateAreaModel Data Structure.
	/// </summary>
	[Serializable]
	public class DateAreaModel : AopObject
	{
		/// <summary>
		///     开始时间
		/// </summary>
		[JsonProperty("begin_date")]
		public string BeginDate { get; set; }

		/// <summary>
		///     结束时间
		/// </summary>
		[JsonProperty("end_date")]
		public string EndDate { get; set; }
	}
}