using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOfflineMarketItemModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOfflineMarketItemModifyModel : AopObject
	{
		/// <summary>
		///     审核规则。支付宝内部使用，外部商户不需填写此字段。
		/// </summary>
		[JsonProperty("audit_rule")]
		public AlipayItemAuditRule AuditRule { get; set; }

		/// <summary>
		///     支付宝内部使用，暂时不支持ISV修改。商品失效时间，只能延长，不能缩短
		/// </summary>
		[JsonProperty("gmt_end")]
		public string GmtEnd { get; set; }

		/// <summary>
		///     库存
		/// </summary>
		[JsonProperty("inventory")]
		public long Inventory { get; set; }

		/// <summary>
		///     口碑体系内部商品的唯一标识
		/// </summary>
		[JsonProperty("item_id")]
		public string ItemId { get; set; }

		/// <summary>
		///     备注
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     商户通知地址，口碑发消息给商户通知其是否对商品创建、修改、变更状态成功
		/// </summary>
		[JsonProperty("operate_notify_url")]
		public string OperateNotifyUrl { get; set; }

		/// <summary>
		///     商品操作上下文。支付宝内部使用，外部商户不需填写此字段。
		/// </summary>
		[JsonProperty("operation_context")]
		public AlipayItemOperationContext OperationContext { get; set; }

		/// <summary>
		///     支持英文字母和数字，由开发者自行定义（不允许重复），在商品notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
		/// </summary>
		[JsonProperty("request_id")]
		public string RequestId { get; set; }

		/// <summary>
		///     支付宝内部参数，ISV不支持修改。销售规则
		/// </summary>
		[JsonProperty("sales_rule")]
		public AlipayItemSalesRule SalesRule { get; set; }

		/// <summary>
		///     商品顺序权重，必须是整数，不传默认为0，权重数值越大排序越靠前
		/// </summary>
		[JsonProperty("weight")]
		public long Weight { get; set; }
	}
}