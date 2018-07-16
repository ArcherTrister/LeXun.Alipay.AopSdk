using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     QueryLabelRule Data Structure.
	/// </summary>
	[Serializable]
	public class QueryLabelRule : AopObject
	{
		/// <summary>
		///     标签id
		/// </summary>
		[JsonProperty("label_id")]
		public string LabelId { get; set; }

		/// <summary>
		///     标签名
		/// </summary>
		[JsonProperty("label_name")]
		public string LabelName { get; set; }

		/// <summary>
		///     标签值，多值会用英文逗号分隔
		/// </summary>
		[JsonProperty("label_value")]
		public string LabelValue { get; set; }

		/// <summary>
		///     运算符
		/// </summary>
		[JsonProperty("operator")]
		public string Operator { get; set; }
	}
}