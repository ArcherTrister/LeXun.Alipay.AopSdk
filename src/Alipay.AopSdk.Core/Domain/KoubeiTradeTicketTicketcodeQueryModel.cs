using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiTradeTicketTicketcodeQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiTradeTicketTicketcodeQueryModel : AopObject
	{
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