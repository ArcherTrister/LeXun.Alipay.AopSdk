using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaCustomerCertificationCertifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaCustomerCertificationCertifyModel : AopObject
	{
		/// <summary>
		///     一次认证的唯一标识,在完成芝麻认证初始化后可以获取
		/// </summary>
		[JsonProperty("biz_no")]
		public string BizNo { get; set; }
	}
}