using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AntMerchantExpandContractFacetofaceQueryModel Data Structure.
	/// </summary>
	[Serializable]
	public class AntMerchantExpandContractFacetofaceQueryModel : AopObject
	{
		/// <summary>
		///     支付宝端商户入驻申请单据号，通过调用ant.merchant.expand.contract.facetoface.sign接口返回的参数中获取
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }

		/// <summary>
		///     外部入驻申请单据号，必须跟ant.merchant.expand.contract.facetoface.sign中的out_biz_no值保持一致
		/// </summary>
		[JsonProperty("out_biz_no")]
		public string OutBizNo { get; set; }
	}
}