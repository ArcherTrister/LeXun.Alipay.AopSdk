using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayOpenPublicMessageTotalSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayOpenPublicMessageTotalSendModel : AopObject
	{
		/// <summary>
		///     图文消息，当msg_type为image-text，该值必须设置
		/// </summary>
		[JsonProperty("articles")]
		
		public List<Article> Articles { get; set; }

		/// <summary>
		///     消息类型，text：文本消息，image-text：图文消息
		/// </summary>
		[JsonProperty("msg_type")]
		public string MsgType { get; set; }

		/// <summary>
		///     文本消息内容，当msg_type为text，必须设置该值
		/// </summary>
		[JsonProperty("text")]
		public Text Text { get; set; }
	}
}