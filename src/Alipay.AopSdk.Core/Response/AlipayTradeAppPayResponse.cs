using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayTradeAppPayResponse.
	/// </summary>
	public class AlipayTradeAppPayResponse : AopResponse
	{
		/// <summary>
		///     商户网站唯一订单号
		/// </summary>
		[JsonProperty("out_trade_no")]
		public string OutTradeNo { get; set; }

		/// <summary>
		///     收款支付宝账号对应的支付宝唯一用户号。  以2088开头的纯16位数字
		/// </summary>
		[JsonProperty("seller_id")]
		public string SellerId { get; set; }

		/// <summary>
		///     该笔订单的资金总额，单位为RMB-Yuan。取值范围为[0.01，100000000.00]，精确到小数点后两位。
		/// </summary>
		[JsonProperty("total_amount")]
		public string TotalAmount { get; set; }

		/// <summary>
		///     该交易在支付宝系统中的交易流水号。
		/// </summary>
		[JsonProperty("trade_no")]
		public string TradeNo { get; set; }
	}
}