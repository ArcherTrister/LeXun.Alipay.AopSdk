using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CampBaseDto Data Structure.
	/// </summary>
	[Serializable]
	public class CampBaseDto : AopObject
	{
		/// <summary>
		///     活动工单列表
		/// </summary>
		[JsonProperty("activity_orders")]
		
		public List<ActivityOrderDTO> ActivityOrders { get; set; }

		/// <summary>
		///     活动审核状态，AUDITING为审核中,REJECT为驳回，不返回为成功
		/// </summary>
		[JsonProperty("audit_status")]
		public string AuditStatus { get; set; }

		/// <summary>
		///     是否自动续期，Y为是，N为否，为空表示否
		/// </summary>
		[JsonProperty("auto_delay_flag")]
		public string AutoDelayFlag { get; set; }

		/// <summary>
		///     截至时间
		/// </summary>
		[JsonProperty("end_time")]
		public string EndTime { get; set; }

		/// <summary>
		///     活动id
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		///     活动名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///     招商状态,GOING招商中，ENDED招商结束，OFFLINE下架
		/// </summary>
		[JsonProperty("plan_status")]
		public string PlanStatus { get; set; }

		/// <summary>
		///     启动时间
		/// </summary>
		[JsonProperty("start_time")]
		public string StartTime { get; set; }

		/// <summary>
		///     活动状态,CREATED:草稿，ENABLED：生效，DISABLED：无效，STARTED：启动，CLOSED：停止，FINISHED：完成
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }

		/// <summary>
		///     活动类型.DIRECT_SEND:直发奖,CONSUME_SEND:消费送
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }
	}
}