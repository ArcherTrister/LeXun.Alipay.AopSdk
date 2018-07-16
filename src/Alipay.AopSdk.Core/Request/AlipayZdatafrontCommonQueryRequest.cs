using System.Collections.Generic;
using Alipay.AopSdk.Core.Response;

namespace Alipay.AopSdk.Core.Request
{
	/// <summary>
	///     AOP API: alipay.zdatafront.common.query
	/// </summary>
	public class AlipayZdatafrontCommonQueryRequest : IAopRequest<AlipayZdatafrontCommonQueryResponse>
	{
		/// <summary>
		///     如果cacheInterval<=0,就直接从外部获取数据；  如果cacheInterval>0,就先判断cache中的数据是否过期，如果没有过期就返回cache中的数据，如果过期再从外部获取数据并刷新cache，然后返回数据。
		///     单位：秒
		/// </summary>
		public long? CacheInterval { get; set; }

		/// <summary>
		///     通用查询的入参
		/// </summary>
		public string QueryConditions { get; set; }

		/// <summary>
		///     服务名称请与相关开发负责人联系
		/// </summary>
		public string ServiceName { get; set; }

		/// <summary>
		///     访问该服务的业务
		/// </summary>
		public string VisitBiz { get; set; }

		/// <summary>
		///     访问该服务的业务线
		/// </summary>
		public string VisitBizLine { get; set; }

		/// <summary>
		///     访问该服务的部门名称
		/// </summary>
		public string VisitDomain { get; set; }

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
			return "alipay.zdatafront.common.query";
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
			parameters.Add("cache_interval", CacheInterval);
			parameters.Add("query_conditions", QueryConditions);
			parameters.Add("service_name", ServiceName);
			parameters.Add("visit_biz", VisitBiz);
			parameters.Add("visit_biz_line", VisitBizLine);
			parameters.Add("visit_domain", VisitDomain);
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