using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineMarketShopQuerydetailModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineMarketShopQuerydetailModel : AopObject
	{
		/// <summary>
		///     服务商及商户调用情况下务必传递。操作人角色，默认商户操作:MERCHANT；服务商操作：PROVIDER；ISV: 不需要填写
		/// </summary>
		[JsonProperty("op_role")]
		public string OpRole { get; set; }

		/// <summary>
		///     支付宝门店ID
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }
	}
}