using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeAboardApplyResponse.
    /// </summary>
    public class AlipayOpenPublicLifeAboardApplyResponse : AopResponse
    {
        /// <summary>
        /// 上架成功后返回的提示
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}