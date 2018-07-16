using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ShopCategoryInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ShopCategoryInfo : AopObject
	{
		/// <summary>
		///     类目编号
		/// </summary>
		[JsonProperty("category_id")]
		public string CategoryId { get; set; }

		/// <summary>
		///     类目层级,目前最多支持1、2、3三级
		/// </summary>
		[JsonProperty("category_level")]
		public string CategoryLevel { get; set; }

		/// <summary>
		///     类目名称
		/// </summary>
		[JsonProperty("category_name")]
		public string CategoryName { get; set; }
	}
}