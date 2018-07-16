using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesQueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesQueryResponse : AopResponse
    {
        /// <summary>
        /// 站点查询返回值
        /// </summary>
        [XmlElement("data")]
        public FengdieSitesQueryRespModel Data { get; set; }
    }
}
