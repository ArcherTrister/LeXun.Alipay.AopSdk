using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayUserCreditCard Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayUserCreditCard : AopObject
	{
		/// <summary>
		///     信用卡卡号，显示前6后2
		/// </summary>
		[JsonProperty("card_no")]
		public string CardNo { get; set; }

		/// <summary>
		///     开户行代码
		/// </summary>
		[JsonProperty("inst_id")]
		public string InstId { get; set; }
	}
}