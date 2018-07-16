using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.ebpp.bill.search
	/// </summary>
	public class AlipayEbppBillSearchRequest : IAopRequest<AlipayEbppBillSearchResponse>
	{
		/// <summary>
		///     账单流水
		/// </summary>
		public string BillKey { get; set; }

		/// <summary>
		///     出账机构
		/// </summary>
		public string ChargeInst { get; set; }

		/// <summary>
		///     销账机构
		/// </summary>
		public string ChargeoffInst { get; set; }

		/// <summary>
		///     销账机构给出账机构分配的id
		/// </summary>
		public string CompanyId { get; set; }

		/// <summary>
		///     必须以key value形式定义，转为json为格式：{"key1":"value1","key2":"value2","key3":"value3","key4":"value4"}
		///     后端会直接转换为MAP对象，转换异常会报参数格式错误
		/// </summary>
		public string Extend { get; set; }

		/// <summary>
		///     业务类型
		/// </summary>
		public string OrderType { get; set; }

		/// <summary>
		///     子业务类型
		/// </summary>
		public string SubOrderType { get; set; }

		#region IAopRequest Members

		private bool needEncrypt;
		private string apiVersion = "1.0";
		private string terminalType;
		private string terminalInfo;
		private string prodCode;
		private string notifyUrl;
		private string returnUrl;
		private AopObject bizModel;

		public void SetNeedEncrypt(bool needEncrypt)
		{
			this.needEncrypt = needEncrypt;
		}

		public bool GetNeedEncrypt()
		{
			return needEncrypt;
		}

		public void SetNotifyUrl(string notifyUrl)
		{
			this.notifyUrl = notifyUrl;
		}

		public string GetNotifyUrl()
		{
			return notifyUrl;
		}

		public void SetReturnUrl(string returnUrl)
		{
			this.returnUrl = returnUrl;
		}

		public string GetReturnUrl()
		{
			return returnUrl;
		}

		public void SetTerminalType(string terminalType)
		{
			this.terminalType = terminalType;
		}

		public string GetTerminalType()
		{
			return terminalType;
		}

		public void SetTerminalInfo(string terminalInfo)
		{
			this.terminalInfo = terminalInfo;
		}

		public string GetTerminalInfo()
		{
			return terminalInfo;
		}

		public void SetProdCode(string prodCode)
		{
			this.prodCode = prodCode;
		}

		public string GetProdCode()
		{
			return prodCode;
		}

		public string GetApiName()
		{
			return "alipay.ebpp.bill.search";
		}

		public void SetApiVersion(string apiVersion)
		{
			this.apiVersion = apiVersion;
		}

		public string GetApiVersion()
		{
			return apiVersion;
		}

		public IDictionary<string, string> GetParameters()
		{
			var parameters = new AopDictionary();
			parameters.Add("bill_key", BillKey);
			parameters.Add("charge_inst", ChargeInst);
			parameters.Add("chargeoff_inst", ChargeoffInst);
			parameters.Add("company_id", CompanyId);
			parameters.Add("extend", Extend);
			parameters.Add("order_type", OrderType);
			parameters.Add("sub_order_type", SubOrderType);
			return parameters;
		}

		public AopObject GetBizModel()
		{
			return bizModel;
		}

		public void SetBizModel(AopObject bizModel)
		{
			this.bizModel = bizModel;
		}

		#endregion
	}
}