using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KoubeiAdvertCommissionChannelModifyModel Data Structure.
	/// </summary>
	[Serializable]
	public class KoubeiAdvertCommissionChannelModifyModel : AopObject
	{
		/// <summary>
		///     修改渠道信息(新增、删除、修改渠道不可同时为空)
		/// </summary>
		[JsonProperty("channels")]
		
		public List<KbAdvertModifyChannelRequest> Channels { get; set; }
	}
}