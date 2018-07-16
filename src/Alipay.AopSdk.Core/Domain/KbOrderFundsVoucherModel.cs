using System;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     KbOrderFundsVoucherModel Data Structure.
	/// </summary>
	[Serializable]
	public class KbOrderFundsVoucherModel : AopObject
	{
		/// <summary>
		///     资金流入账户,打款动作存在该字段
		/// </summary>
		[JsonProperty("account")]
		public string Account { get; set; }

		/// <summary>
		///     金额
		/// </summary>
		[JsonProperty("amount")]
		public string Amount { get; set; }

		/// <summary>
		///     资金凭证ID
		/// </summary>
		[JsonProperty("funds_voucher_no")]
		public string FundsVoucherNo { get; set; }

		/// <summary>
		///     资金流转发生时间
		/// </summary>
		[JsonProperty("gmt_create")]
		public string GmtCreate { get; set; }

		/// <summary>
		///     门店ID，打款动作存在该字段
		/// </summary>
		[JsonProperty("shop_id")]
		public string ShopId { get; set; }

		/// <summary>
		///     资金流入外部门店ID，打款时存在该字段
		/// </summary>
		[JsonProperty("store_id")]
		public string StoreId { get; set; }

		/// <summary>
		///     资金类型  PAY/SETTLE/REFUND 对应 支付／打款／退款
		/// </summary>
		[JsonProperty("trans_type")]
		public string TransType { get; set; }
	}
}