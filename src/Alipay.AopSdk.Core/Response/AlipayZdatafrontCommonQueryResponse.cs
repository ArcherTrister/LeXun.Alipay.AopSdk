using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayZdatafrontCommonQueryResponse.
	/// </summary>
	public class AlipayZdatafrontCommonQueryResponse : AopResponse
	{
		/// <summary>
		///     数据的时间戳：  如果fromCache=false,timestamp就是从外部返回的数据时间，如果外部返回的数据没有时间字段，就以系统取到的时间；
		///     如果fromCache=true，timestamp就是从cache中获取的数据时间
		/// </summary>
		[JsonProperty("cache_timestamp")]
		public long CacheTimestamp { get; set; }

		/// <summary>
		///     数据结果集，统一按照String类型返回
		/// </summary>
		[JsonProperty("values")]
		public string Values { get; set; }
	}
}