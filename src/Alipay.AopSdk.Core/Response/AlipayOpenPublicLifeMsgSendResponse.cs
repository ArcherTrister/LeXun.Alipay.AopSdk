using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicLifeMsgSendResponse.
	/// </summary>
	public class AlipayOpenPublicLifeMsgSendResponse : AopResponse
	{
		/// <summary>
		///     生活号消息唯一标识
		/// </summary>
		[JsonProperty("alipay_msg_id")]
		public string AlipayMsgId { get; set; }
	}
}