using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     McardTemplateBenefitQuery Data Structure.
	/// </summary>
	[Serializable]
	public class McardTemplateBenefitQuery : AopObject
	{
		/// <summary>
		///     权益描述信息
		/// </summary>
		[JsonProperty("benefit_desc")]
		public string BenefitDesc { get; set; }

		/// <summary>
		///     权益ID
		/// </summary>
		[JsonProperty("benefit_id")]
		public string BenefitId { get; set; }

		/// <summary>
		///     权益结束时间
		/// </summary>
		[JsonProperty("end_date")]
		public string EndDate { get; set; }

		/// <summary>
		///     会员卡模板权益扩展信息：JSON格式; openUrl 说明：跳转到商户的优惠活动页面
		/// </summary>
		[JsonProperty("ext_info")]
		public string ExtInfo { get; set; }

		/// <summary>
		///     权益开始时间
		/// </summary>
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		/// <summary>
		///     会员卡模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }

		/// <summary>
		///     权益标题
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}