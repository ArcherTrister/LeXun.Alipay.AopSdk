using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileCodeQueryResponse.
	/// </summary>
	public class AlipayMobileCodeQueryResponse : AopResponse
	{
		/// <summary>
		///     业务关联ID。比如订单号,userId，业务连接等
		/// </summary>
		[JsonProperty("biz_linked_id")]
		public string BizLinkedId { get; set; }

		/// <summary>
		///     类似产品名称，根据该值决定码存储类型
		/// </summary>
		[JsonProperty("biz_type")]
		public string BizType { get; set; }

		/// <summary>
		///     码值的状态，  init:初始  normal:正常  pause:暂停  stop:停止
		/// </summary>
		[JsonProperty("code_status")]
		public string CodeStatus { get; set; }

		/// <summary>
		///     业务自定义json字符串。
		/// </summary>
		[JsonProperty("context_str")]
		public string ContextStr { get; set; }

		/// <summary>
		///     动态生成图片地址
		/// </summary>
		[JsonProperty("dynamic_img_url")]
		public string DynamicImgUrl { get; set; }

		/// <summary>
		///     编码失效时间(yyyy-MM-dd hh:mm:ss)
		/// </summary>
		[JsonProperty("expire_date")]
		public string ExpireDate { get; set; }

		/// <summary>
		///     如果是true，则扫一扫下发跳转地址直接取自BizLinkedId  否则，从路由信息里取跳转地址
		/// </summary>
		[JsonProperty("is_direct")]
		public string IsDirect { get; set; }

		/// <summary>
		///     备注信息
		/// </summary>
		[JsonProperty("memo")]
		public string Memo { get; set; }

		/// <summary>
		///     业务用到的码值
		/// </summary>
		[JsonProperty("qr_code")]
		public string QrCode { get; set; }

		/// <summary>
		///     原始码值
		/// </summary>
		[JsonProperty("qr_token")]
		public string QrToken { get; set; }

		/// <summary>
		///     发码来源，业务自定
		/// </summary>
		[JsonProperty("source_id")]
		public string SourceId { get; set; }

		/// <summary>
		///     编码启动时间(yyyy-MM-dd hh:mm:ss)
		/// </summary>
		[JsonProperty("start_date")]
		public string StartDate { get; set; }

		/// <summary>
		///     支付宝用户id
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}