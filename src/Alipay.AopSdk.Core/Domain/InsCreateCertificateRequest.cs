using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InsCreateCertificateRequest Data Structure.
	/// </summary>
	[Serializable]
	public class InsCreateCertificateRequest : AopObject
	{
		/// <summary>
		///     扩展字段
		/// </summary>
		[JsonProperty("biz_data")]
		public string BizData { get; set; }

		/// <summary>
		///     保险凭证类型
		/// </summary>
		[JsonProperty("certificate_type")]
		public string CertificateType { get; set; }

		/// <summary>
		///     生效时间
		/// </summary>
		[JsonProperty("effect_time")]
		public string EffectTime { get; set; }

		/// <summary>
		///     失效时间
		/// </summary>
		[JsonProperty("expire_time")]
		public string ExpireTime { get; set; }

		/// <summary>
		///     面值
		/// </summary>
		[JsonProperty("face_value")]
		public string FaceValue { get; set; }

		/// <summary>
		///     电子保单号
		/// </summary>
		[JsonProperty("ins_policy_no")]
		public string InsPolicyNo { get; set; }

		/// <summary>
		///     机构id
		/// </summary>
		[JsonProperty("inst_id")]
		public string InstId { get; set; }

		/// <summary>
		///     订单id
		/// </summary>
		[JsonProperty("order_id")]
		public string OrderId { get; set; }

		/// <summary>
		///     订单来源
		/// </summary>
		[JsonProperty("order_source")]
		public string OrderSource { get; set; }

		/// <summary>
		///     外部业务单号
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }

		/// <summary>
		///     拥有人uid
		/// </summary>
		[JsonProperty("owner_uid")]
		public string OwnerUid { get; set; }
	}
}