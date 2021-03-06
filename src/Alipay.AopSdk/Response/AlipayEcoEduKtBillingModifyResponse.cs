using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayEcoEduKtBillingModifyResponse.
    /// </summary>
    public class AlipayEcoEduKtBillingModifyResponse : AopResponse
    {
        /// <summary>
        /// 如果成功，返回Y
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }
    }
}
