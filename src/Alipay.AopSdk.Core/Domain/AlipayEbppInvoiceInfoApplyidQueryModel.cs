using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEbppInvoiceInfoApplyidQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEbppInvoiceInfoApplyidQueryModel : AopObject
	{
		/// <summary>
		///     申请开票时支付宝返回的申请id，具有全局唯一性。
		/// </summary>
		[JsonProperty("apply_id")]
		public string ApplyId { get; set; }
	}
}