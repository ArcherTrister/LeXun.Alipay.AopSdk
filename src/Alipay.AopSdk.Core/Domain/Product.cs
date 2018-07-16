using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     Product Data Structure.
	/// </summary>
	[Serializable]
	public class Product : AopObject
	{
		/// <summary>
		///     油品编号。（可设置的油品编号名称：89#，92#，95#，98#，101#，10#，5#，0#，-10#，-20#，-35#，-50#）。
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     油品价格（元/升），加油站列表页展示给用户。保留小数点后两位，单位元
		/// </summary>
		[JsonProperty("price")]
		public string Price { get; set; }
	}
}