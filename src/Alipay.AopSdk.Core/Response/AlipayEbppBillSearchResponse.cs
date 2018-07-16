using System.Collections.Generic;
using Newtonsoft.Json;
using Alipay.AopSdk.Core.Domain;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEbppBillSearchResponse.
	/// </summary>
	public class AlipayEbppBillSearchResponse : AopResponse
	{
		/// <summary>
		///     已经缓存的的key
		/// </summary>
		[JsonProperty("cachekey")]
		public string Cachekey { get; set; }

		/// <summary>
		///     实时查询欠费单返回对象
		/// </summary>
		[JsonProperty("inst_bill_info_list")]
		
		public List<QueryInstBillInfo> InstBillInfoList { get; set; }
	}
}