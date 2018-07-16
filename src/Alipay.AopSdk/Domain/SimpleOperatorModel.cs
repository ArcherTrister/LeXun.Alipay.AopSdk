using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// SimpleOperatorModel Data Structure.
    /// </summary>
    [Serializable]
    public class SimpleOperatorModel : AopObject
    {
        /// <summary>
        /// 操作员id
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 操作员类型，只区分收银员和非收银员  收银员为“RESTRICTED_CASHIER”，非收银员为“STANDARD_NORMAL”
        /// </summary>
        [XmlElement("operator_type")]
        public string OperatorType { get; set; }
    }
}
