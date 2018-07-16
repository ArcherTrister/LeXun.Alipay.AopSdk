using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsProdTag Data Structure.
	/// </summary>
	[Serializable]
	public class InsProdTag : AopObject
	{
		/// <summary>
		///     业务标记代码
		/// </summary>
		[JsonProperty("tag_code")]
		public string TagCode { get; set; }

		/// <summary>
		///     业务标记值
		/// </summary>
		[JsonProperty("tag_value")]
		public string TagValue { get; set; }
	}
}