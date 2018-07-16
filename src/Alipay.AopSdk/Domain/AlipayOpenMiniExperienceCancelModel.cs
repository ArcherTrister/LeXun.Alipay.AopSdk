using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayOpenMiniExperienceCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniExperienceCancelModel : AopObject
    {
        /// <summary>
        /// 小程序版本号
        /// </summary>
        [XmlElement("app_version")]
        public string AppVersion { get; set; }
    }
}
