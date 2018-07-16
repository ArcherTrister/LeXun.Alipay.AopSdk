using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.micropay.order.confirmpayurl.get
	/// </summary>
	public class AlipayMicropayOrderConfirmpayurlGetRequest : IAopRequest<AlipayMicropayOrderConfirmpayurlGetResponse>
	{
		/// <summary>
		///     支付宝订单号，冻结流水号.这个是创建冻结订单支付宝返回的
		/// </summary>
		public string AlipayOrderNo { get; set; }

		/// <summary>
		///     支付金额,区间必须在[0.01,30]，只能保留小数点后两位
		/// </summary>
		public string Amount { get; set; }

		/// <summary>
		///     支付备注
		/// </summary>
		public string Memo { get; set; }

		/// <summary>
		///     收款方的支付宝ID
		/// </summary>
		public string ReceiveUserId { get; set; }

		/// <summary>
		///     本次转账的外部单据号（只能由字母和数字组成,maxlength=32）
		/// </summary>
		public string TransferOutOrderNo { get; set; }

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
			return "alipay.micropay.order.confirmpayurl.get";
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
			parameters.Add("alipay_order_no", AlipayOrderNo);
			parameters.Add("amount", Amount);
			parameters.Add("memo", Memo);
			parameters.Add("receive_user_id", ReceiveUserId);
			parameters.Add("transfer_out_order_no", TransferOutOrderNo);
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