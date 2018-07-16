using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignItemQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignItemQueryModel : AopObject
	{
		/// <summary>
		///     商品id
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; }

		/// <summary>
		///     操作人id
		/// </summary>
		[JsonProperty("operator_id")]
		public string OperatorId { get; set; }

		/// <summary>
		///     操作员类型，MER=商户
		/// </summary>
		[JsonProperty("operator_type")]
		public string OperatorType { get; set; }
	}
}