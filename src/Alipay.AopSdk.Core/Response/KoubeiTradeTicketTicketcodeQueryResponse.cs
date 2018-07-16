using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     KoubeiTradeTicketTicketcodeQueryResponse.
	/// </summary>
	public class KoubeiTradeTicketTicketcodeQueryResponse : AopResponse
	{
		/// <summary>
		///     用户购买时商品的现价
		/// </summary>
		[JsonProperty("current_price")]
		public string CurrentPrice { get; set; }

		/// <summary>
		///     券生效时间
		/// </summary>
		[JsonProperty("effect_date")]
		public string EffectDate { get; set; }

		/// <summary>
		///     券失效时间
		/// </summary>
		[JsonProperty("expire_date")]
		public string ExpireDate { get; set; }

		/// <summary>
		///     口碑商品ID
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; }

		/// <summary>
		///     商品名称
		/// </summary>
		[JsonProperty("item_name")]
		public string ItemName { get; set; }

		/// <summary>
		///     凭证对应的订单号
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }

		/// <summary>
		///     用户购买时商品的原价
		/// </summary>
		[JsonProperty("original_price")]
		public string OriginalPrice { get; set; }

		/// <summary>
		///     12位的券码，券码为纯数字，且唯一不重复
		/// </summary>
		[JsonProperty("ticket_code")]
		public string TicketCode { get; set; }

		/// <summary>
		///     券状态  1.  USED:该券已经被消费,无法核销  2.  EFFECTIVE:未核销，且可以在当前门店核销  3.  UN_EFFECTIVE:未核销，但不可以在当前门店核销  4.
		///     REFUNDED:该券已经退款,无法核销  5.  USING:核销处理中,无法核销  6.  REFUNDING:退款处理中,无法核销
		/// </summary>
		[JsonProperty("ticket_status")]
		public string TicketStatus { get; set; }

		/// <summary>
		///     券状态描述  1.  该券已经被消费，无法核销  2.  未核销，且可以在当前门店核销  3.  未核销，但不可以在当前门店核销  4.  该券已经退款，无法核销  5.  该券正在核销处理中,无法核销  6.
		///     该券正在退款处理中,无法核销
		/// </summary>
		[JsonProperty("ticket_status_desc")]
		public string TicketStatusDesc { get; set; }

		/// <summary>
		///     凭证的流水记录
		/// </summary>
		[JsonProperty("ticket_trans_info_list")]
		
		public List<TicketTransInfo> TicketTransInfoList { get; set; }

		/// <summary>
		///     券码对应的凭证资产id
		/// </summary>
		[JsonProperty("voucher_id")]
		public string VoucherId { get; set; }
	}
}