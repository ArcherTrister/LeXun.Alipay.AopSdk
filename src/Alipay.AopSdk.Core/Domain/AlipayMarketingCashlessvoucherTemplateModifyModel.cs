using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingCashlessvoucherTemplateModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingCashlessvoucherTemplateModifyModel : AopObject
	{
		/// <summary>
		///     模板修改操作外部业务号，用于修改时的幂等控制，注意这里不是修改业务号
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     发放结束时间，晚于该时间不能发券。券的发放结束时间和发放开始时间跨度不能大于90天。发放结束时间必须晚于发放开始时间。格式为：yyyy-MM-dd HH:mm:ss。
		/// </summary>
		[JsonProperty("publish_end_time")]
		public string PublishEndTime { get; set; }

		/// <summary>
		///     规则配置，JSON字符串，{"PID": "2088512417841101,2088512417841102", "STORE":
		///     "123456,678901"}，其中PID表示可以核销该券的pid列表，多个值用英文逗号隔开，STORE表示可以核销该券的内部门店ID，多个值用英文逗号隔开，不传此参数则不修改规则，若有要修改规则那么必须包含PID，规则修改仅支持代金券
		/// </summary>
		[JsonProperty("rule_conf")]
		public string RuleConf { get; set; }

		/// <summary>
		///     券模板ID ，参数值通过调用alipay.marketing.cashlessvoucher.template.create接口返回
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }
	}
}