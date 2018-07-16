using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorDepositConfirmModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceCityfacilitatorDepositConfirmModel : AopObject
	{
		/// <summary>
		///     传递确认的终端信息，终端编号等
		/// </summary>
		[JsonProperty("biz_info_ext")]
		public string BizInfoExt { get; set; }

		/// <summary>
		///     交通卡号
		/// </summary>
		[JsonProperty("card_no")]
		public string CardNo { get; set; }

		/// <summary>
		///     交通卡卡类型，一个城市只有一个固定的值
		/// </summary>
		[JsonProperty("card_type")]
		public string CardType { get; set; }

		/// <summary>
		///     核销时间
		/// </summary>
		[JsonProperty("operate_time")]
		public string OperateTime { get; set; }

		/// <summary>
		///     商户的交易号
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     该笔请求的唯一编号，强校验，控制幂等性
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }

		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}