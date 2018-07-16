using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayMarketingVoucherTemplatelistQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayMarketingVoucherTemplatelistQueryModel : AopObject
	{
		/// <summary>
		///     模板创建结束时间，格式为：yyyy-MM-dd HH:mm:ss
		/// </summary>
		[JsonProperty("create_end_time")]
		public string CreateEndTime { get; set; }

		/// <summary>
		///     模板创建开始时间，格式为：yyyy-MM-dd HH:mm:ss
		/// </summary>
		[JsonProperty("create_start_time")]
		public string CreateStartTime { get; set; }

		/// <summary>
		///     页码，必须为大于0的整数， 1表示第一页，2表示第2页，依次类推。
		/// </summary>
		[JsonProperty("page_num")]
		public long PageNum { get; set; }

		/// <summary>
		///     每页记录条数，必须为大于0的整数，最大值为30
		/// </summary>
		[JsonProperty("page_size")]
		public long PageSize { get; set; }
	}
}