using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AlipayPassTemplateUpdateModel Data Structure.
	/// </summary>
	[Serializable]
	public class AlipayPassTemplateUpdateModel : AopObject
	{
		/// <summary>
		///     模板内容信息，遵循JSON规范，详情参见tpl_content参数说明:https://doc.open.alipay.com/doc2/detail.htm?treeId=193&articleId=105249&docType
		///     =1#tpl_content
		/// </summary>
		[JsonProperty("tpl_content")]
		public string TplContent { get; set; }

		/// <summary>
		///     更新的模板ID
		/// </summary>
		[JsonProperty("tpl_id")]
		public string TplId { get; set; }
	}
}