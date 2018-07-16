using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.pass.code.add
	/// </summary>
	public class AlipayPassCodeAddRequest : IAopRequest<AlipayPassCodeAddResponse>
	{
		/// <summary>
		///     alipass文件Base64编码后的内容。
		/// </summary>
		public string FileContent { get; set; }

		/// <summary>
		///     识别信息  当 recognition_type=1时， recognition_info={“partner_id”:”2088102114633762”,“out_trade_no”:”1234567”}
		///     当recognition_type=2时， recognition_info={“user_id”:”2088102114633761“ }
		/// </summary>
		public string RecognitionInfo { get; set; }

		/// <summary>
		///     发放对象识别类型  1- 订单信息  2- 支付宝userId
		/// </summary>
		public string RecognitionType { get; set; }

		/// <summary>
		///     该pass的核销方式,如果为空，则默认为["wave","qrcode"]
		/// </summary>
		public List<string> VerifyType { get; set; }

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
			return "alipay.pass.code.add";
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
			parameters.Add("file_content", FileContent);
			parameters.Add("recognition_info", RecognitionInfo);
			parameters.Add("recognition_type", RecognitionType);
			parameters.Add("verify_type", VerifyType);
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