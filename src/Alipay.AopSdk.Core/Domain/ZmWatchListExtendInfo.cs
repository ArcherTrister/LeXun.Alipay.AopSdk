using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZmWatchListExtendInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ZmWatchListExtendInfo : AopObject
	{
		/// <summary>
		///     对于这个key的描述
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		///     对应的字段名
		/// </summary>
		[JsonProperty("key")]
		public string Key { get; set; }

		/// <summary>
		///     对应的值
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}