using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BizListDataInfo Data Structure.
	/// </summary>
	[Serializable]
	public class BizListDataInfo : AopObject
	{
		/// <summary>
		///     下拉列表编号
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		///     下拉列表名称
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}