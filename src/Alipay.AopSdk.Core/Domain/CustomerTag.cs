using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CustomerTag Data Structure.
	/// </summary>
	[Serializable]
	public class CustomerTag : AopObject
	{
		/// <summary>
		///     字段名称
		/// </summary>
		[JsonProperty("col_name")]
		public string ColName { get; set; }

		/// <summary>
		///     column_type字段类型
		/// </summary>
		[JsonProperty("column_type")]
		public string ColumnType { get; set; }

		/// <summary>
		///     id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     标签名
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}