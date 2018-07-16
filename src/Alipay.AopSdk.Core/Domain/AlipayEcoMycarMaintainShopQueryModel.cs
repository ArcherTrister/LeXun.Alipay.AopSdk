using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarMaintainShopQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarMaintainShopQueryModel : AopObject
	{
		/// <summary>
		///     外部门店编号（与shop_id二选一，不能都为空）
		/// </summary>
		[JsonProperty("out_shop_id")]
		public string OutShopId { get; set; }

		/// <summary>
		///     车主平台门店编号（与out_shop_id二选一，不能都为空）
		/// </summary>
		[JsonProperty("shop_id")]
		public long ShopId { get; set; }
	}
}