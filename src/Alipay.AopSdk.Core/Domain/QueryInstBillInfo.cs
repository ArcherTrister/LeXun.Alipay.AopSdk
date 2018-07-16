using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Alipay.AopSdk.Core.Domain
{
	/// <summary>
	///     QueryInstBillInfo Data Structure.
	/// </summary>
	[Serializable]
	public class QueryInstBillInfo : AopObject
	{
		/// <summary>
		///     账单金额
		/// </summary>
		[JsonProperty("amount")]
		public string Amount { get; set; }

		/// <summary>
		///     余额
		/// </summary>
		[JsonProperty("balance")]
		public string Balance { get; set; }

		/// <summary>
		///     账单日期
		/// </summary>
		[JsonProperty("bill_date")]
		public string BillDate { get; set; }

		/// <summary>
		///     明细说明
		/// </summary>
		[JsonProperty("bill_detail")]
		
		public List<QueryInstBillDetail> BillDetail { get; set; }

		/// <summary>
		///     滞纳金
		/// </summary>
		[JsonProperty("bill_fines")]
		public string BillFines { get; set; }

		/// <summary>
		///     账单流水
		/// </summary>
		[JsonProperty("bill_key")]
		public string BillKey { get; set; }

		/// <summary>
		///     户名
		/// </summary>
		[JsonProperty("bill_user_name")]
		public string BillUserName { get; set; }

		/// <summary>
		///     JDBXINHUI
		/// </summary>
		[JsonProperty("charge_inst")]
		public string ChargeInst { get; set; }

		/// <summary>
		///     查询欠费单的惟一标识
		/// </summary>
		[JsonProperty("charge_uniq_id")]
		public string ChargeUniqId { get; set; }

		/// <summary>
		///     销账机构
		/// </summary>
		[JsonProperty("chargeoff_inst")]
		public string ChargeoffInst { get; set; }

		/// <summary>
		///     销账机构给出账机构分配的ID
		/// </summary>
		[JsonProperty("company_id")]
		public string CompanyId { get; set; }

		/// <summary>
		///     扩展属性
		/// </summary>
		[JsonProperty("extend")]
		public string Extend { get; set; }

		/// <summary>
		///     业务类型
		/// </summary>
		[JsonProperty("order_type")]
		public string OrderType { get; set; }

		/// <summary>
		///     外部流水号
		/// </summary>
		[JsonProperty("out_id")]
		public string OutId { get; set; }

		/// <summary>
		///     错误信息
		/// </summary>
		[JsonProperty("return_message")]
		public string ReturnMessage { get; set; }

		/// <summary>
		///     子业务类型
		/// </summary>
		[JsonProperty("sub_order_type")]
		public string SubOrderType { get; set; }
	}
}