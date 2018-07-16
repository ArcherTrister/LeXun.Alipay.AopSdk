using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesDeleteResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesDeleteResponse : AopResponse
    {
        /// <summary>
        /// 返回删除云凤蝶站点成功与失败的结果
        /// </summary>
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
