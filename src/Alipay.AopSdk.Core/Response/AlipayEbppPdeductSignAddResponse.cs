using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEbppPdeductSignAddResponse.
	/// </summary>
	public class AlipayEbppPdeductSignAddResponse : AopResponse
	{
		/// <summary>
		///     支付宝代扣协议ID
		/// </summary>
		[JsonProperty("agreement_id")]
		public string AgreementId { get; set; }

		/// <summary>
		///     支付宝协议状态。签约成功则返回success
		/// </summary>
		[JsonProperty("agreement_status")]
		public string AgreementStatus { get; set; }

		/// <summary>
		///     扩展参数，可为空
		/// </summary>
		[JsonProperty("extend_field")]
		public string ExtendField { get; set; }

		/// <summary>
		///     通知方式设置。
		/// </summary>
		[JsonProperty("notify_config")]
		public string NotifyConfig { get; set; }

		/// <summary>
		///     商户生成的代扣协议ID
		/// </summary>
		[JsonProperty("out_agreement_id")]
		public string OutAgreementId { get; set; }

		/// <summary>
		///     支付方式设置
		/// </summary>
		[JsonProperty("pay_config")]
		
		public List<string> PayConfig { get; set; }

		/// <summary>
		///     签约时间
		/// </summary>
		[JsonProperty("sign_date")]
		public string SignDate { get; set; }
	}
}