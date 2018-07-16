using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     OpenPromoPrizeRelativeTime Data Structure.
	/// </summary>
	[Serializable]
	public class OpenPromoPrizeRelativeTime : AopObject
	{
		/// <summary>
		///     时间维度,       MI：表示 分       H：表示 时       D：表示 日       W：表示 周       M：表示 月
		/// </summary>
		[JsonProperty("dimension")]
		public string Dimension { get; set; }

		/// <summary>
		///     相对值
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}