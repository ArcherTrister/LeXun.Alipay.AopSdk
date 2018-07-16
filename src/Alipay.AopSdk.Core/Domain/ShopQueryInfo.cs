using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ShopQueryInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ShopQueryInfo : AopObject
	{
		/// <summary>
		///     门店地址
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		///     是否包含同mid下的其他pid的店铺
		/// </summary>
		[JsonProperty("is_include_cognate")]
		public bool IsIncludeCognate { get; set; }

		/// <summary>
		///     纬度
		/// </summary>
		[JsonProperty("latitude")]
		public string Latitude { get; set; }

		/// <summary>
		///     经度
		/// </summary>
		[JsonProperty("longitude")]
		public string Longitude { get; set; }

		/// <summary>
		///     门店名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     商户pid
		/// </summary>
		[JsonProperty("pid")]
		public string Pid { get; set; }

		/// <summary>
		///     内部门店ID
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }

		/// <summary>
		///     门店类型
		/// </summary>
		[JsonProperty("shop_type")]
		public string ShopType { get; set; }

		/// <summary>
		///     外部门店ID
		/// </summary>
		[JsonProperty("store_id")]
		public string StoreId { get; set; }
	}
}