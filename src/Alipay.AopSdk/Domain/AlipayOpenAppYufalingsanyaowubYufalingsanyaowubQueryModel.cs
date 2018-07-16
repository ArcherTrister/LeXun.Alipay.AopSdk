using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel : AopObject
    {
        /// <summary>
        /// yufaa
        /// </summary>
        [XmlElement("yufaa")]
        public string Yufaa { get; set; }
    }
}
