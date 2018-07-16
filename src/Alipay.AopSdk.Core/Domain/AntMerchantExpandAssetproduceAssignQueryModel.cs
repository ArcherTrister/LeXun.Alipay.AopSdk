using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AntMerchantExpandAssetproduceAssignQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AntMerchantExpandAssetproduceAssignQueryModel : AopObject
	{
		/// <summary>
		///     每次拉取最大记录数量，可选值为[1,200] ;
		/// </summary>
		[JsonProperty("page_size")]
		public long PageSize { get; set; }
	}
}