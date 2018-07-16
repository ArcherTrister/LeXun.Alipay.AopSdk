using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ZhimaAuthInfoAuthqueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class ZhimaAuthInfoAuthqueryModel : AopObject
	{
		/// <summary>
		///     json格式的内容,包含userId,userId为支付宝用户id,用户授权后商户可以拿到这个支付宝userId
		/// </summary>
		[JsonProperty("identity_param")]
		public string IdentityParam { get; set; }
	}
}