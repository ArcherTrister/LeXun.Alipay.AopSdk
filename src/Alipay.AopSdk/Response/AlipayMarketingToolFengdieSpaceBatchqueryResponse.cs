using System;
using System.Xml.Serialization;
using Alipay.AopSdk.Domain;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSpaceBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSpaceBatchqueryResponse : AopResponse
    {
        /// <summary>
        /// 云凤蝶空间列表查询接口返回值，包含分页信息，空间信息的列表。
        /// </summary>
        [XmlElement("data")]
        public FengdieSpaceListRespModel Data { get; set; }
    }
}
