using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     AssetParams Data Structure.
	/// </summary>
	[Serializable]
	public class AssetParams : AopObject
	{
		/// <summary>
		///     资产类型：  1. BANK（银行卡）  2. ACCOUNT（账号模式）
		/// </summary>
		[JsonProperty("asset_type")]
		public string AssetType { get; set; }

		/// <summary>
		///     银行卡号。  assetType为BANK时，必填。
		/// </summary>
		[JsonProperty("card_no")]
		public string CardNo { get; set; }

		/// <summary>
		///     机构ID。  assetType为BANK时，必填。
		/// </summary>
		[JsonProperty("inst_id")]
		public string InstId { get; set; }
	}
}