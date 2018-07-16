using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayCommerceCityfacilitatorVoucherCancelModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayCommerceCityfacilitatorVoucherCancelModel : AopObject
	{
		/// <summary>
		///     渠道商提供的其它信息
		/// </summary>
		[JsonProperty("biz_info_ext")]
		public string BizInfoExt { get; set; }

		/// <summary>
		///     城市标准码
		/// </summary>
		[JsonProperty("city_code")]
		public string CityCode { get; set; }

		/// <summary>
		///     商户退款时间
		/// </summary>
		[JsonProperty("operate_time")]
		public string OperateTime { get; set; }

		/// <summary>
		///     核销号
		/// </summary>
		[JsonProperty("ticket_no")]
		public string TicketNo { get; set; }

		/// <summary>
		///     支付宝交易号
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}