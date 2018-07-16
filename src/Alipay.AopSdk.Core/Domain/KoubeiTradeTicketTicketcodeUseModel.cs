using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiTradeTicketTicketcodeUseModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiTradeTicketTicketcodeUseModel : AopObject
	{
		/// <summary>
		///     外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }

		/// <summary>
		///     口碑门店id
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }

		/// <summary>
		///     12位的券码，券码为纯数字，且唯一不重复
		/// </summary>
		[JsonProperty("ticket_code")]
		public string TicketCode { get; set; }
	}
}