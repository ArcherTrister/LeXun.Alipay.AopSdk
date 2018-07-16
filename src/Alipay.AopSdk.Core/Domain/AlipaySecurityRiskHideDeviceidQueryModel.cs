using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipaySecurityRiskHideDeviceidQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipaySecurityRiskHideDeviceidQueryModel : AopObject
	{
		/// <summary>
		///     商户的sdk客户端key
		/// </summary>
		[JsonProperty("app_key_client")]
		public string AppKeyClient { get; set; }

		/// <summary>
		///     商户使用的设备指纹服务端key
		/// </summary>
		[JsonProperty("app_key_server")]
		public string AppKeyServer { get; set; }

		/// <summary>
		///     商户应用名称
		/// </summary>
		[JsonProperty("app_name")]
		public string AppName { get; set; }

		/// <summary>
		///     设备指纹deviceid对应的token
		/// </summary>
		[JsonProperty("deviceid_token")]
		public string DeviceidToken { get; set; }
	}
}