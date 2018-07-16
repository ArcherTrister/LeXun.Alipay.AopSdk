using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CraftsmanSubAssessment Data Structure.
	/// </summary>
	[Serializable]
	public class CraftsmanSubAssessment : AopObject
	{
		/// <summary>
		///     子评分
		/// </summary>
		[JsonProperty("score")]
		public long Score { get; set; }

		/// <summary>
		///     子评分项名
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}