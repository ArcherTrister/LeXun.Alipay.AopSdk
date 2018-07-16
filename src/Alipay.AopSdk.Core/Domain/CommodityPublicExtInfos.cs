using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     CommodityPublicExtInfos Data Structure.
	/// </summary>
	[Serializable]
	public class CommodityPublicExtInfos : AopObject
	{
		/// <summary>
		///     前置url
		/// </summary>
		[JsonProperty("action_url")]
		public string ActionUrl { get; set; }

		/// <summary>
		///     应用展台id
		/// </summary>
		[JsonProperty("app_id")]
		public string AppId { get; set; }

		/// <summary>
		///     类目
		/// </summary>
		[JsonProperty("category_name")]
		public string CategoryName { get; set; }

		/// <summary>
		///     城市名称
		/// </summary>
		[JsonProperty("city_name")]
		public string CityName { get; set; }

		/// <summary>
		///     服务插件ID
		/// </summary>
		[JsonProperty("commodity_id")]
		public string CommodityId { get; set; }

		/// <summary>
		///     创建者ID
		/// </summary>
		[JsonProperty("create_user_id")]
		public string CreateUserId { get; set; }

		/// <summary>
		///     挂载ID，用于确认唯一记录的主键对象
		/// </summary>
		[JsonProperty("displayapp_id")]
		public string DisplayappId { get; set; }

		/// <summary>
		///     城市服务说明
		/// </summary>
		[JsonProperty("displayapp_memo")]
		public string DisplayappMemo { get; set; }

		/// <summary>
		///     服务别名
		/// </summary>
		[JsonProperty("displayapp_name")]
		public string DisplayappName { get; set; }

		/// <summary>
		///     状态 1:上架；0：下架；2:维护中
		/// </summary>
		[JsonProperty("displayapp_status")]
		public string DisplayappStatus { get; set; }

		/// <summary>
		///     用户访问地址
		/// </summary>
		[JsonProperty("displayapp_url")]
		public string DisplayappUrl { get; set; }

		/// <summary>
		///     外部展示地址
		/// </summary>
		[JsonProperty("export_url")]
		public string ExportUrl { get; set; }

		/// <summary>
		///     属性ID
		/// </summary>
		[JsonProperty("property_id")]
		public string PropertyId { get; set; }
	}
}