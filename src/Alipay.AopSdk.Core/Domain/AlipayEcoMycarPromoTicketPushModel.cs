using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarPromoTicketPushModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarPromoTicketPushModel : AopObject
	{
		/// <summary>
		///     核销流水
		/// </summary>
		[JsonProperty("apply_no")]
		public string ApplyNo { get; set; }

		/// <summary>
		///     核销状态，0：成功，1：失败
		/// </summary>
		[JsonProperty("apply_status")]
		public string ApplyStatus { get; set; }

		/// <summary>
		///     对应TP活动码
		/// </summary>
		[JsonProperty("code_no")]
		public string CodeNo { get; set; }

		/// <summary>
		///     券ID
		/// </summary>
		[JsonProperty("ticket_id")]
		public string TicketId { get; set; }
	}
}