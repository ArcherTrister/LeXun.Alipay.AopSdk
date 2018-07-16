using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayDataDataserviceChinaremodelQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayDataDataserviceChinaremodelQueryModel : AopObject
	{
		/// <summary>
		///     体检记录id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     规则id
		/// </summary>
		[JsonProperty("rule_id")]
		public string RuleId { get; set; }

		/// <summary>
		///     交易流水记录id
		/// </summary>
		[JsonProperty("trans_id")]
		public string TransId { get; set; }
	}
}