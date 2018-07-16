using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayInsAutoCarSaveModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayInsAutoCarSaveModel : AopObject
	{
		/// <summary>
		///     车牌号
		/// </summary>
		[JsonProperty("car_no")]
		public string CarNo { get; set; }

		/// <summary>
		///     用户ID,车主会员ID
		/// </summary>
		[JsonProperty("user_id")]
		public string UserId { get; set; }
	}
}