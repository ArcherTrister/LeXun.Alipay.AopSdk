using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiTradeOrderConsultModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiTradeOrderConsultModel : AopObject
	{
		/// <summary>
		///     商品明细列表。注意：单品总金额不能大于订单金额
		/// </summary>
		[JsonProperty("goods_info")]
		
		public List<GoodsInfo> GoodsInfo { get; set; }

		/// <summary>
		///     唯一请求id，开放者请确保每次请求的唯一性
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }

		/// <summary>
		///     支付宝门店编号
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }

		/// <summary>
		///     订单总金额，单位元，精确到小数点后两位，取值范围[0.01,999999999]  如果同时传入了【不可打折金额】，【订单总金额】两者，则必须满足【不可打折金额】<=【订单总金额】
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }

		/// <summary>
		///     不参与优惠计算的金额，单位为元，精确到小数点后两位，取值范围[0,999999999]  如果同时传入了【不可打折金额】、【订单总金额】，则必须满足【不可打折金额】<=【订单总金额】
		/// </summary>
		[JsonProperty("undiscountable_amount")]
		public string UndiscountableAmount { get; set; }

		/// <summary>
		///     支付宝用户Id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}