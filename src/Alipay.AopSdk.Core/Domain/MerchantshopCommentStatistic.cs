using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     MerchantshopCommentStatistic Data Structure.
	/// </summary>
	[Serializable]
	public class MerchantshopCommentStatistic : AopObject
	{
		/// <summary>
		///     评论总数
		/// </summary>
		[JsonProperty("comment_count")]
		public long CommentCount { get; set; }

		/// <summary>
		///     评分（平均分），两位小数
		/// </summary>
		[JsonProperty("score")]
		public long Score { get; set; }
	}
}