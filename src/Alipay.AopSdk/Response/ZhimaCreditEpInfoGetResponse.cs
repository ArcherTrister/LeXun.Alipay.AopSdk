using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// ZhimaCreditEpInfoGetResponse.
    /// </summary>
    public class ZhimaCreditEpInfoGetResponse : AopResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 企业工商综合信息
        /// </summary>
        [XmlElement("company_info")]
        public CompanyInfo CompanyInfo { get; set; }
    }
}
