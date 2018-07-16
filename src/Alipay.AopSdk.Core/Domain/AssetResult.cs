using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AssetResult Data Structure.
	/// </summary>
	[Serializable]
	public class AssetResult : AopObject
	{
		/// <summary>
		///     订单明细ID
		/// </summary>
		[JsonProperty("assign_item_id")]
		public string AssignItemId { get; set; }

		/// <summary>
		///     错误码
		/// </summary>
		[JsonProperty("error_code")]
		public string ErrorCode { get; set; }

		/// <summary>
		///     错误描述
		/// </summary>
		[JsonProperty("error_desc")]
		public string ErrorDesc { get; set; }

		/// <summary>
		///     是否处理成功
		/// </summary>
		[JsonProperty("success")]
		public bool Success { get; set; }
	}
}