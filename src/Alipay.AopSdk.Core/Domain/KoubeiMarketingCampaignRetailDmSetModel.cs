using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignRetailDmSetModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignRetailDmSetModel : AopObject
	{
		/// <summary>
		///     下架时间，仅上架操作时使用，必须晚于当前时间
		/// </summary>
		[JsonProperty("campaign_end_time")]
		public string CampaignEndTime { get; set; }

		/// <summary>
		///     内容ID，调用koubei.marketing.campaign.retail.dm.create创建内容时返回的内容ID
		/// </summary>
		[JsonProperty("content_id")]
		public string ContentId { get; set; }

		/// <summary>
		///     上下架操作类型，上架：ONLINE，下架：OFFLINE，注意：请先调用创建内容接口再进行上架操作，下架内容不得再上架。
		/// </summary>
		[JsonProperty("operate_type")]
		public string OperateType { get; set; }
	}
}