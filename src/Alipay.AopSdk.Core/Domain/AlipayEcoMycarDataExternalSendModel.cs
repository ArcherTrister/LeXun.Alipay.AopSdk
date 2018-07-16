using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayEcoMycarDataExternalSendModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayEcoMycarDataExternalSendModel : AopObject
	{
		/// <summary>
		///     external_system_name
		/// </summary>
		[JsonProperty("external_system_name")]
		public string ExternalSystemName { get; set; }

		/// <summary>
		///     is_transfer_uid
		/// </summary>
		[JsonProperty("is_transfer_uid")]
		public string IsTransferUid { get; set; }

		/// <summary>
		///     operate_type
		/// </summary>
		[JsonProperty("operate_type")]
		public string OperateType { get; set; }

		/// <summary>
		///     send_data
		/// </summary>
		[JsonProperty("send_data")]
		public string SendData { get; set; }
	}
}