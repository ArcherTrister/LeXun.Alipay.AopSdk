using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// ReportErrorFeature Data Structure.
    /// </summary>
    [Serializable]
    public class ReportErrorFeature : AopObject
    {
        /// <summary>
        /// 桌号
        /// </summary>
        [XmlElement("table_num")]
        public string TableNum { get; set; }
    }
}
