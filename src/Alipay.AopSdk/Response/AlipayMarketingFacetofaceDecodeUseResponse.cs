using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayMarketingFacetofaceDecodeUseResponse.
    /// </summary>
    public class AlipayMarketingFacetofaceDecodeUseResponse : AopResponse
    {
        /// <summary>
        /// 用户userId
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
