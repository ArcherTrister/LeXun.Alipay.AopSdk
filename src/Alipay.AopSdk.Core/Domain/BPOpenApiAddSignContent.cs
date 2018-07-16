using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     BPOpenApiAddSignContent Data Structure.
	/// </summary>
	[Serializable]
	public class BPOpenApiAddSignContent : AopObject
	{
		/// <summary>
		///     自定义的条件跳转。JSON格式
		/// </summary>
		[JsonProperty("additional_lines")]
		
		public List<string> AdditionalLines { get; set; }

		/// <summary>
		///     任务处理人的域账号列表
		/// </summary>
		[JsonProperty("assignee")]
		public string Assignee { get; set; }

		/// <summary>
		///     自定义操作
		/// </summary>
		[JsonProperty("deal_actions")]
		public string DealActions { get; set; }

		/// <summary>
		///     任务处理链接。如果不填，则使用流程平台默认地址
		/// </summary>
		[JsonProperty("deal_url")]
		public string DealUrl { get; set; }

		/// <summary>
		///     详情查看地址。如果不填写，则使用流程平台默认详情地址
		/// </summary>
		[JsonProperty("detail_url")]
		public string DetailUrl { get; set; }

		/// <summary>
		///     处理节点展示名称
		/// </summary>
		[JsonProperty("display_name")]
		public string DisplayName { get; set; }
	}
}