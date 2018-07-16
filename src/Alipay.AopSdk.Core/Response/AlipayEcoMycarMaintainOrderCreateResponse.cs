using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayEcoMycarMaintainOrderCreateResponse.
	/// </summary>
	public class AlipayEcoMycarMaintainOrderCreateResponse : AopResponse
	{
		/// <summary>
		///     业务订单编号，规则28位；yyMMddHHmmss&#160;+&#160;&#160;行业标识3位+模块标识2位&#160;+uid（后六位）&#160;+序列值（5位）
		/// </summary>
		[JsonProperty("order_no")]
		public string OrderNo { get; set; }
	}
}