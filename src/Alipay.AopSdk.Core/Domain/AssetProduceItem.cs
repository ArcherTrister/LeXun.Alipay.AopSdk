using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AssetProduceItem Data Structure.
	/// </summary>
	[Serializable]
	public class AssetProduceItem : AopObject
	{
		/// <summary>
		///     申请日期，格式yyyy-MM-dd HH：mm:ss
		/// </summary>
		[JsonProperty("apply_date")]
		public string ApplyDate { get; set; }

		/// <summary>
		///     申请单号
		/// </summary>
		[JsonProperty("apply_order_id")]
		public string ApplyOrderId { get; set; }

		/// <summary>
		///     收钱码吊牌和贴纸类型不为空;   物料图片Url，供应商使用该图片进行物料打印
		/// </summary>
		[JsonProperty("asset_pic_url")]
		public string AssetPicUrl { get; set; }

		/// <summary>
		///     订单明细ID
		/// </summary>
		[JsonProperty("assign_item_id")]
		public string AssignItemId { get; set; }

		/// <summary>
		///     city
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }

		/// <summary>
		///     数量
		/// </summary>
		[JsonProperty("count")]
		public string Count { get; set; }

		/// <summary>
		///     订单创建时间, 格式: yyyy-MM-dd HH：mm:ss
		/// </summary>
		[JsonProperty("create_date")]
		public string CreateDate { get; set; }

		/// <summary>
		///     1 - 旧模式, 需要在生产完成后反馈运单号 ; 2 - 新模式, 不需要在生产完成后反馈运单号
		/// </summary>
		[JsonProperty("data_version")]
		public string DataVersion { get; set; }

		/// <summary>
		///     区
		/// </summary>
		[JsonProperty("district")]
		public string District { get; set; }

		/// <summary>
		///     收钱码吊牌和贴纸类型不为空
		/// </summary>
		[JsonProperty("logistics_name")]
		public string LogisticsName { get; set; }

		/// <summary>
		///     物流运单号; 收钱码吊牌和贴纸类型不为空
		/// </summary>
		[JsonProperty("logistics_no")]
		public string LogisticsNo { get; set; }

		/// <summary>
		///     收件人地址邮编; 收钱码吊牌和贴纸类型不为空
		/// </summary>
		[JsonProperty("postcode")]
		public string Postcode { get; set; }

		/// <summary>
		///     省
		/// </summary>
		[JsonProperty("province")]
		public string Province { get; set; }

		/// <summary>
		///     收货人地址
		/// </summary>
		[JsonProperty("receiver_address")]
		public string ReceiverAddress { get; set; }

		/// <summary>
		///     联系人电话
		/// </summary>
		[JsonProperty("receiver_mobile")]
		public string ReceiverMobile { get; set; }

		/// <summary>
		///     收货人姓名
		/// </summary>
		[JsonProperty("receiver_name")]
		public string ReceiverName { get; set; }

		/// <summary>
		///     物料供应商PID，和调用方的供应商PID一致
		/// </summary>
		[JsonProperty("supplier_pid")]
		public string SupplierPid { get; set; }

		/// <summary>
		///     模板ID
		/// </summary>
		[JsonProperty("template_id")]
		public string TemplateId { get; set; }

		/// <summary>
		///     模板名称，线下约定的物料名称
		/// </summary>
		[JsonProperty("template_name")]
		public string TemplateName { get; set; }
	}
}