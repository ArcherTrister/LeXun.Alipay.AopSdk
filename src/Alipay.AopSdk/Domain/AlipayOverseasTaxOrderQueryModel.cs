using System;
using System.Xml.Serialization;

namespace Alipay.AopSdk.Domain
{
    /// <summary>
    /// AlipayOverseasTaxOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOverseasTaxOrderQueryModel : AopObject
    {
        /// <summary>
        /// 退税机构业务流水号，唯一，由退税机构生成，只能包含英字母、数字，长度不能小于3且不能大于64
        /// </summary>
        [XmlElement("out_order_no")]
        public string OutOrderNo { get; set; }
    }
}
