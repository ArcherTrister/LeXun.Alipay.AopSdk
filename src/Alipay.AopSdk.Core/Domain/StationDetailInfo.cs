using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     StationDetailInfo Data Structure.
	/// </summary>
	[Serializable]
	public class StationDetailInfo : AopObject
	{
		/// <summary>
		///     站点编码
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     站点外部编码
		/// </summary>
		[JsonProperty("ext_code")]
		public string ExtCode { get; set; }

		/// <summary>
		///     站点中文名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}