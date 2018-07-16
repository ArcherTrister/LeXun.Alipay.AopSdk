using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CustomsDeclareBuyerInfo Data Structure.
	/// </summary>
	[Serializable]
	public class CustomsDeclareBuyerInfo : AopObject
	{
		/// <summary>
		///     订购人身份证号。即订购人留在商户处的身份证信息
		/// </summary>
		[JsonProperty("buyer_cert_no")]
		public string BuyerCertNo { get; set; }

		/// <summary>
		///     订购人姓名。即订购人留在商户处的姓名信息
		/// </summary>
		[JsonProperty("buyer_name")]
		public string BuyerName { get; set; }
	}
}