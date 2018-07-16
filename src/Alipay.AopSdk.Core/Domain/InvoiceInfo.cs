using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     InvoiceInfo Data Structure.
	/// </summary>
	[Serializable]
	public class InvoiceInfo : AopObject
	{
		/// <summary>
		///     开票内容  注：json数组格式
		/// </summary>
		[JsonProperty("details")]
		public string Details { get; set; }

		/// <summary>
		///     开票关键信息
		/// </summary>
		[JsonProperty("key_info")]
		public InvoiceKeyInfo KeyInfo { get; set; }
	}
}