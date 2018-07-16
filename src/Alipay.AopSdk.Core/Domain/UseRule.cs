using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     UseRule Data Structure.
	/// </summary>
	[Serializable]
	public class UseRule : AopObject
	{
		/// <summary>
		///     扩展属性，无需设置
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     券的不可用时间
		/// </summary>
		[JsonProperty("forbidden_time")]
		public ForbbidenTime ForbiddenTime { get; set; }

		/// <summary>
		///     优惠券的使用支付渠道限制规则，  不受支付渠道限制:USE_NO_LIMIT;  仅限储值卡支付时可用:USE_ON_CURRENT_PAY_CHANNEL;  储值卡支付时不可用:NOT_ALLOWED_USE;  【备注】
		///     支付渠道限制不允许修改
		/// </summary>
		[JsonProperty("limit_rule")]
		public string LimitRule { get; set; }

		/// <summary>
		///     券核销的最低消费门槛，单位元
		/// </summary>
		[JsonProperty("min_consume")]
		public string MinConsume { get; set; }

		/// <summary>
		///     券买单跳转链接
		/// </summary>
		[JsonProperty("pay_redirect_url")]
		public string PayRedirectUrl { get; set; }

		/// <summary>
		///     券适用门店列表  仅品牌商发起的招商活动可为空  直发奖类型活动必须与活动适用门店一致  最多支持10w家门店
		/// </summary>
		[JsonProperty("suit_shops")]
		
		public List<string> SuitShops { get; set; }

		/// <summary>
		///     券可用时间段
		/// </summary>
		[JsonProperty("use_time")]
		
		public List<UseTime> UseTime { get; set; }
	}
}