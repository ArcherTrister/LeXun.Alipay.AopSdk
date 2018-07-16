using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Response
{
	/// <summary>
	///     AlipayOpenPublicMenuCreateResponse.
	/// </summary>
	public class AlipayOpenPublicMenuCreateResponse : AopResponse
	{
		/// <summary>
		///     默认菜单菜单key，文本菜单为“default”，icon菜单为“iconDefault”
		/// </summary>
		[JsonProperty("menu_key")]
		public string MenuKey { get; set; }
	}
}