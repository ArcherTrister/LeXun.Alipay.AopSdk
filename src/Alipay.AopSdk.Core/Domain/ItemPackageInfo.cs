using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     ItemPackageInfo Data Structure.
	/// </summary>
	[Serializable]
	public class ItemPackageInfo : AopObject
	{
		/// <summary>
		///     商品详情-套餐内菜品信息列表
		/// </summary>
		[JsonProperty("item_units")]
		
		public List<ItemUnitInfo> ItemUnits { get; set; }

		/// <summary>
		///     商品详情-套餐标题。最多不超过15个汉字，30个字符
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }
	}
}