using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiMarketingCampaignActivityCreateModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiMarketingCampaignActivityCreateModel : AopObject
	{
		/// <summary>
		///     是否自动续期活动，默认为N,只有当对应营销工具券有效期为相对有效期时才能设置成Y
		/// </summary>
		[JsonProperty("auto_delay_flag")]
		public string AutoDelayFlag { get; set; }

		/// <summary>
		///     活动预算（当活动类型为GUESS_SEND且营销工具PromoTool的数量大于1时，即口令随机送活动，活动预算为空，每张券的预算数量落在SendRule里的send_budget）
		/// </summary>
		[JsonProperty("budget_info")]
		public BudgetInfo BudgetInfo { get; set; }

		/// <summary>
		///     活动限制信息
		/// </summary>
		[JsonProperty("constraint_info")]
		public ConstraintInfo ConstraintInfo { get; set; }

		/// <summary>
		///     活动详细说明
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		///     活动结束时间
		/// </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary>
		///     活动的扩展信息，无需设置
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     活动名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     操作人id，必须和operator_type配对出现，不填时默认是商户
		/// </summary>
		[JsonProperty("operator_id")]
		public string OperatorId { get; set; }

		/// <summary>
		///     操作人类型,有以下值可填：MER（外部商户），MER_OPERATOR（外部商户操作员），PROVIDER（外部服务商），PROVIDER_STAFF（外部服务商员工），默认不需要填这个字段，默认为MER
		/// </summary>
		[JsonProperty("operator_type")]
		public string OperatorType { get; set; }

		/// <summary>
		///     外部批次ID，同一owner创建活动需要换out_biz_no，控制幂等
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     营销工具集
		/// </summary>
		[JsonProperty("promo_tools")]
		
		public List<PromoTool> PromoTools { get; set; }

		/// <summary>
		///     投放渠道集，当活动类型为DIRECT_SEND或者REAL_TIME_SEND时必填，当活动类型为CONSUME_SEND时必须为空，当活动类型为GUESS_SEND时，投放渠道只能有一个且type只能为MERCHANT_CROWD
		/// </summary>
		[JsonProperty("publish_channels")]
		
		public List<PublishChannel> PublishChannels { get; set; }

		/// <summary>
		///     招商工具信息
		/// </summary>
		[JsonProperty("recruit_tool")]
		public RecruitTool RecruitTool { get; set; }

		/// <summary>
		///     活动开始时间
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary>
		///     活动类型，目前支持以下类型：  CONSUME_SEND：消费送活动  DIRECT_SEND：直发奖活动  REAL_TIME_SEND：实时立减类活动  GUESS_SEND：口令送  RECHARGE_SEND：充值送
		///     POINT_SEND：集点卡活动
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}