using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayMobileStdPublicMenuQueryResponse.
	/// </summary>
	public class AlipayMobileStdPublicMenuQueryResponse : AopResponse
	{
		/// <summary>
		///     所有菜单列表json串
		/// </summary>
		[JsonProperty("all_menu_list")]
		public string AllMenuList { get; set; }
	}
}